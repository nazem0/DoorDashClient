using System;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public class QuoteResponse
{
	[JsonPropertyName("delivery_time")]
	public DateTimeOffset DeliveryTime { get; set; }
	[JsonPropertyName("fee")]
	public int Fee { get; set; }
	[JsonPropertyName("pickup_time")]
	public DateTimeOffset PickupTime { get; set; }
	[JsonPropertyName("currency")]
	public string Currency { get; set; }
	[JsonPropertyName("id")]
	public int Id { get; set; }
}
