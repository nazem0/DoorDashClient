using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	/// <summary>
	/// A Doordash Classic quote request.
	/// Rules:
	/// </summary>
	public class QuoteRequest
	{
		[JsonPropertyName("pickup_address")]
		public Address PickupAddress { get; set; }
		[JsonPropertyName("dropoff_address")]
		[Required]
		public Address DropoffAddress { get; set; }
		[JsonPropertyName("order_value")]
		[Required]
		public int OrderValue { get; set; }
		[JsonPropertyName("delivery_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? DeliveryTime { get; set; }
		[JsonPropertyName("pickup_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? PickupTime { get; set; }
		[JsonPropertyName("external_store_id")]
		[Required]
		public string ExternalStoreId { get; set; }
		[JsonPropertyName("external_business_name")]
		[Required]
		public string ExternalBusinessName { get; set; }
		[JsonPropertyName("promotion_id")]
		public string PromotionId { get; set; }
	}
}
