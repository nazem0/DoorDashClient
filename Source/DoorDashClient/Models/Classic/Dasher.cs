using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public class Dasher
{
	public int Id { get; set; }
	[JsonPropertyName("first_name")]
	public string FirstName { get; set; }
	[JsonPropertyName("last_name")]
	public string LastName { get; set; }
	[JsonPropertyName("phone_number")]
	public string PhoneNumber { get; set; }
	[JsonPropertyName("dasher_phone_number_for_customer")]
	public string DasherPhoneNumberForCustomer { get; set; }
	public Location Location { get; set; }
}
