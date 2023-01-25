using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public class Address
{
	[JsonPropertyName("city")]
	public string City { get; set; }
	[JsonPropertyName("state")]
	public string State { get; set; }
	[JsonPropertyName("street")]
	public string Street { get; set; }
	[JsonPropertyName("unit")]
	public string Unit { get; set; }
	[JsonPropertyName("zip_code")]
	public string ZipCode { get; set; }
}
