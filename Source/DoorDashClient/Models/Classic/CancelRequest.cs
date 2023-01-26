using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public class CancelRequest
{
	[JsonPropertyName("reason_code")]

	public string? ReasonCode { get; set; }
}
