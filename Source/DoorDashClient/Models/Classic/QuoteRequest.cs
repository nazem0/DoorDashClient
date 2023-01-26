using System;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public class QuoteRequest
	{
		[JsonPropertyName("pickup_address")]
		public Address PickupAddress { get; set; }
		[JsonPropertyName("dropoff_address")]
		public Address DropoffAddress { get; set; }
		[JsonPropertyName("order_value")]
		public int OrderValue { get; set; }
		[JsonPropertyName("delivery_time")]
		public DateTimeOffset? DeliveryTime { get; set; }
		[JsonPropertyName("pickup_time")]
		public DateTimeOffset? PickupTime { get; set; }
		[JsonPropertyName("external_store_id")]
		public string ExternalStoreId { get; set; }
		[JsonPropertyName("external_business_name")]
		public string ExternalBusinessName { get; set; }
		[JsonPropertyName("promotion_id")]
		public string PromotionId { get; set; }
	}
}
