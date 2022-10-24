namespace DoorDashClient.Models;

/// <summary>
/// Doordash settings and credentials.
/// </summary>
public record DoorDashSettings
{
	/// <summary>
	/// The section name to put settings under in appsettings.
	/// </summary>
	public const string SectionName = "DoorDash";
	/// <summary>
	/// The base URL for which Doordash calls are made. Default is openapi.
	/// </summary>
	public string? BaseUrl { get; set; } = "https://openapi.doordash.com";
	/// <summary>
	/// The Doordash developer ID made from creating an account.
	/// </summary>
	public string? DeveloperId { get; set; }
	/// <summary>
	/// The access key ID from creating credentials.
	/// </summary>
	public string? KeyId { get; set; }
	/// <summary>
	/// The signing secret key from creating credentials.
	/// </summary>
	public string? SigningSecret { get; set; }
}
