using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public class Address
	{
		[JsonPropertyName("city")]
		[Required]
		public string City { get; set; }
		[JsonPropertyName("state")]
		[Required]
		public string State { get; set; }
		[JsonPropertyName("street")]
		[Required]
		public string Street { get; set; }
		[JsonPropertyName("unit")]
		public string Unit { get; set; }
		[JsonPropertyName("zip_code")]
		[Required]
		public string ZipCode { get; set; }
	}
}
