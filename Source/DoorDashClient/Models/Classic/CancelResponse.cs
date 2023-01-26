using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public class CancelResponse
{
	[JsonPropertyName("return_initiated")]
	public bool ReturnInitiated { get; set; }
	[JsonPropertyName("cancelled_at")]
	public string? CancelledAt { get; set; }
}
