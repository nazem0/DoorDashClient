using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public class DeliveryResponse
	{
		[JsonPropertyName("rating")]
		public string Rating { get; set; }
		[JsonPropertyName("pickup_window_start_time")]
		public DateTimeOffset? PickupWindowStartTime { get; set; }
		[JsonPropertyName("pickup_window_end_time")]
		public DateTimeOffset? PickupWindowEndTime { get; set; }
		[JsonPropertyName("delivery_window_start_time")]
		public DateTimeOffset? DeliveryWindowStartTime { get; set; }
		[JsonPropertyName("delivery_window_end_time")]
		public DateTimeOffset? DeliveryWindowEndTime { get; set; }
		[JsonPropertyName("actual_return_time")]
		public DateTimeOffset? ActualReturnTime { get; set; }
		[JsonPropertyName("driver_reference_tag")]
		public string DriverReferenceTag { get; set; }
		[JsonPropertyName("contains_alcohol")]
		public bool? ContainsAlcohol { get; set; }
		[JsonPropertyName("updated_at")]
		public DateTimeOffset? UpdatedAt { get; set; }
		public string Currency { get; set; }
		[JsonPropertyName("estimated_pickup_time")]
		public DateTimeOffset? EstimatedPickupTime { get; set; }
		[JsonPropertyName("order_volume")]
		public long OrderVolume { get; set; }
		[JsonPropertyName("id")]
		public long Id { get; set; }
		[JsonPropertyName("dasher_status")]
		public string DasherStatus { get; set; }
		[JsonPropertyName("estimated_delivery_time")]
		public DateTimeOffset? EstimatedDeliveryTime { get; set; }
		public long Fee { get; set; }
		[JsonPropertyName("quoted_pickup_time")]
		public DateTimeOffset? QuotedPickupTime { get; set; }
		[JsonPropertyName("dropoff_address")]
		public Address DropoffAddress { get; set; }
		[JsonPropertyName("allow_unattended_delivery")]
		public bool? AllowUnattendedDelivery { get; set; }
		public int? Tip { get; set; }
		[JsonPropertyName("team_lift_required")]
		public bool? TeamLiftRequired { get; set; }
		[JsonPropertyName("external_store_id")]
		public string ExternalStoreId { get; set; }
		[JsonPropertyName("pickup_instructions")]
		public string PickupInstructions { get; set; }
		public Dasher Dasher { get; set; }
		public string Status { get; set; }
		[JsonPropertyName("quoted_delivery_time")]
		public DateTimeOffset? QuotedDeliveryTime { get; set; }
		[JsonPropertyName("actual_pickup_time")]
		public DateTimeOffset? ActualPickupTime { get; set; }
		[JsonPropertyName("signature_required")]
		public bool? SignatureRequired { get; set; }
		[JsonPropertyName("pickup_address")]
		public Address PickupAddress { get; set; }
		[JsonPropertyName("barcode_scanning_required")]
		public bool? BarcodeScanningRequired { get; set; }
		[JsonPropertyName("delivery_tracking_url")]
		public string DeliveryTrackingUrl { get; set; }
		[JsonPropertyName("external_delivery_id")]
		public string ExternalDeliveryId { get; set; }
		public Customer Customer { get; set; }
		[JsonPropertyName("order_value")]
		public long OrderValue { get; set; }
		public IEnumerable<Item> Items { get; set; }
		[JsonPropertyName("dropoff_instructions")]
		public string DropoffInstructions { get; set; }
		[JsonPropertyName("actual_delivery_time")]
		public string ActualDeliveryTime { get; set; }
		[JsonPropertyName("signature_image_url")]
		public string SignatureImageUrl { get; set; }
		public long Quantity { get; set; }
		[JsonPropertyName("delivery_verification_image_url")]
		public string DeliveryVerificationImageUrl { get; set; }
		[JsonPropertyName("pickup_verification_image_url")]
		public string PickupVerificationImageUrl { get; set; }
		[JsonPropertyName("relationship_type")]
		public string RelationshipType { get; set; }
		[JsonPropertyName("relationship_description")]
		public string RelationshipDescription { get; set; }
	}
}
