using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DoorDashClient;
using Refit;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using DoorDashClient.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using DoorDashClient.Clients;
using System.Net.Http;

namespace DoorDashClient
{
	public static class DependencyRegistrations
	{
		/// <summary>
		/// Adds the Drive API v2 Doordash client.
		/// </summary>
		/// <param name="services">The <see cref="IServiceCollection"/> to configure</param>
		/// <param name="services">The <see cref="IConfiguration"/> to configure</param>
		/// <remarks>Make sure your Doordash settings in appsettings are set.</remarks>
		public static void AddDoordashDriveV2(this IServiceCollection services, IConfiguration config)
		{
			var doorDashConfig = new DoorDashSettings();
			config.Bind(DoorDashSettings.SectionName, doorDashConfig);

			services.AddRefitClient<IDoorDashV2Client>()
				.ConfigureHttpClient((HttpClient client) =>
				{
					SetupHttpClient(client, doorDashConfig);
				});
		}

		/// <summary>
		/// Adds the Drive API Classic Doordash client.
		/// </summary>
		/// <param name="services">The <see cref="IServiceCollection"/> to configure</param>
		/// <param name="services">The <see cref="IConfiguration"/> to configure</param>
		/// <remarks>Make sure your Doordash settings in appsettings are set.</remarks>
		public static void AddDoordashDriveClassic(this IServiceCollection services, IConfiguration config)
		{
			var doorDashConfig = new DoorDashSettings();
			config.Bind(DoorDashSettings.SectionName, doorDashConfig);

			services.AddRefitClient<IDoorDashClassicClient>()
				.ConfigureHttpClient((HttpClient client) =>
				{
					SetupHttpClient(client, doorDashConfig);
				});
		}

		/// <summary>
		/// Sets up a Doordash Refit client so a proper token is sent with each request.
		/// </summary>
		/// <param name="client">The http client</param>
		/// <param name="doorDashConfig">The doordash configuration object</param>
		private static void SetupHttpClient(HttpClient client, DoorDashSettings doorDashConfig)
		{
			client.BaseAddress = new Uri(doorDashConfig.BaseUrl);

			// Create JWT from DD settings
			var accessKey = new Dictionary<string, string>{
				  {"developer_id", doorDashConfig.DeveloperId},
				  {"key_id", doorDashConfig.KeyId},
				  {"signing_secret", doorDashConfig.SigningSecret}
				};

			byte[] decodedSecret = Base64UrlEncoder.DecodeBytes(accessKey["signing_secret"]);
			var securityKey = new SymmetricSecurityKey(decodedSecret);
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var header = new JwtHeader(credentials)
			{
				["dd-ver"] = "DD-JWT-V1"
			};

			var payload = new JwtPayload(
			issuer: accessKey["developer_id"],
			audience: "doordash",
			claims: new List<Claim> { new Claim("kid", accessKey["key_id"]) },
			notBefore: null,
			expires: DateTime.UtcNow.AddSeconds(60),
			issuedAt: DateTime.UtcNow);

			var securityToken = new JwtSecurityToken(header, payload);
			string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
		}
	}
}
