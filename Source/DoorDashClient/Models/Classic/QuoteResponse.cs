using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public class QuoteResponse
	{
		[JsonPropertyName("delivery_time")]
		[Required]
		public DateTimeOffset DeliveryTime { get; set; }
		[JsonPropertyName("fee")]
		[Required]
		public long Fee { get; set; }
		[JsonPropertyName("pickup_time")]
		[Required]
		public DateTimeOffset PickupTime { get; set; }
		[JsonPropertyName("currency")]
		[Required]
		public string Currency { get; set; }
		[JsonPropertyName("id")]
		[Required]
		public long Id { get; set; }
	}
}
