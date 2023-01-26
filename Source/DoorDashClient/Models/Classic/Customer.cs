using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public partial class Customer
{
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; }

	[JsonPropertyName("business_name")]
	public string? BusinessName { get; set; }

	[JsonPropertyName("first_name")]
	public string? FirstName { get; set; }

	[JsonPropertyName("last_name")]
	public string? LastName { get; set; }

	[JsonPropertyName("email")]
	public string? Email { get; set; }

	[JsonPropertyName("should_send_notifications")]
	[JsonConverter(typeof(BoolConverter))]
	public bool? ShouldSendNotifications { get; set; }

	[JsonPropertyName("locale")]
	public string? Locale { get; set; }
}
