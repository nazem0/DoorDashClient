using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public class UpdateDeliveryRequest
	{
		[JsonPropertyName("pickup_business_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PickupBusinessName { get; set; }

		[JsonPropertyName("pickup_instructions")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PickupInstructions { get; set; }

		[JsonPropertyName("pickup_phone_number")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PickupPhoneNumber { get; set; }

		[JsonPropertyName("quoted_pickup_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? QuotedPickupTime { get; set; }

		[JsonPropertyName("quoted_delivery_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? QuotedDeliveryTime { get; set; }

		[JsonPropertyName("pickup_window_start_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? PickupWindowStartTime { get; set; }

		[JsonPropertyName("pickup_window_end_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? PickupWindowEndTime { get; set; }

		[JsonPropertyName("delivery_window_start_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? DeliveryWindowStartTime { get; set; }

		[JsonPropertyName("delivery_window_end_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? DeliveryWindowEndTime { get; set; }

		[JsonPropertyName("dropoff_address")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public Address DropoffAddress { get; set; }

		[JsonPropertyName("first_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string CustomerFirstName { get; set; }

		[JsonPropertyName("last_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string CustomerLastName { get; set; }

		[JsonPropertyName("business_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string CustomerBusinessName { get; set; }

		[JsonPropertyName("customer_phone_number")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string CustomerPhoneNumber { get; set; }

		[JsonPropertyName("dropoff_special_instructions")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string DropoffSpecialInstructions { get; set; }

		[JsonPropertyName("signature_required")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool SignatureRequired { get; set; }

		[JsonPropertyName("allow_unattended_delivery")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool AllowUnattendedDelivery { get; set; }

		[JsonPropertyName("contains_alcohol")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool ContainsAlcohol { get; set; }

		[JsonPropertyName("delivery_metadata")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public Dictionary<string, string> DeliveryMetadata { get; set; }

		[JsonPropertyName("allowed_vehicles")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public IEnumerable<string> AllowedVehicles { get; set; }

		[JsonPropertyName("tip")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public int Tip { get; set; }

		[JsonPropertyName("order_ready_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? OrderReadyTime { get; set; }
	}
}
