using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public partial class DeliveryRequest
	{
		[JsonPropertyName("pickup_address")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public Address PickupAddress { get; set; }

		[JsonPropertyName("pickup_phone_number")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PickupPhoneNumber { get; set; }

		[JsonPropertyName("dropoff_address")]
		[Required]
		public Address DropoffAddress { get; set; }

		[JsonPropertyName("customer")]
		[Required]
		public Customer Customer { get; set; }

		[JsonPropertyName("order_value")]
		[Required]
		public int OrderValue { get; set; }

		[JsonPropertyName("pickup_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? PickupTime { get; set; }

		[JsonPropertyName("delivery_time")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public DateTimeOffset? DeliveryTime { get; set; }

		[JsonPropertyName("items")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public List<Item> Items { get; set; }

		[JsonPropertyName("team_lift_required")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool TeamLiftRequired { get; set; }

		[JsonPropertyName("barcode_scanning_required")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool BarcodeScanningRequired { get; set; }

		[JsonPropertyName("pickup_business_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PickupBusinessName { get; set; }

		[JsonPropertyName("pickup_instructions")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PickupInstructions { get; set; }

		[JsonPropertyName("dropoff_instructions")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string DropoffInstructions { get; set; }

		[JsonPropertyName("tip")]
		public int Tip { get; set; }

		[JsonPropertyName("external_delivery_id")]
		public string ExternalDeliveryId { get; set; }

		[JsonPropertyName("driver_reference_tag")]
		public string DriverReferenceTag { get; set; }

		[JsonPropertyName("external_business_name")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string ExternalBusinessName { get; set; }

		[JsonPropertyName("external_business_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string ExternalBusinessId { get; set; }

		[JsonPropertyName("external_store_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string ExternalStoreId { get; set; }

		[JsonPropertyName("contains_alcohol")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool ContainsAlcohol { get; set; }

		[JsonPropertyName("requires_catering_setup")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool RequiresCateringSetup { get; set; }

		[JsonPropertyName("num_items")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public int NumItems { get; set; }

		[JsonPropertyName("signature_required")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool SignatureRequired { get; set; }

		[JsonPropertyName("allow_unattended_delivery")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool AllowUnattendedDelivery { get; set; }

		[JsonPropertyName("cash_on_delivery")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public int CashOnDelivery { get; set; }

		[JsonPropertyName("delivery_metadata")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public Dictionary<string, string> DeliveryMetadata { get; set; }

		[JsonPropertyName("allowed_vehicles")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public IEnumerable<string> AllowedVehicles { get; set; }

		[JsonPropertyName("is_contactless_delivery")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public bool IsContactlessDelivery { get; set; }

		[JsonPropertyName("promotion_id")]
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public string PromotionId { get; set; }
	}
}
