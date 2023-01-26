using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public partial class DeliveryDetailsResponse
{
	[JsonPropertyName("rating")]
	public string? Rating { get; set; }

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
	public string? DriverReferenceTag { get; set; }

	[JsonPropertyName("contains_alcohol")]
	public bool ContainsAlcohol { get; set; }

	[JsonPropertyName("updated_at")]
	public DateTimeOffset? UpdatedAt { get; set; }

	[JsonPropertyName("currency")]
	public string? Currency { get; set; }

	[JsonPropertyName("estimated_pickup_time")]
	public DateTimeOffset? EstimatedPickupTime { get; set; }

	[JsonPropertyName("order_volume")]
	public long OrderVolume { get; set; }

	[JsonPropertyName("id")]
	public long Id { get; set; }

	[JsonPropertyName("dasher_status")]
	public string? DasherStatus { get; set; }

	[JsonPropertyName("estimated_delivery_time")]
	public DateTimeOffset? EstimatedDeliveryTime { get; set; }

	[JsonPropertyName("fee")]
	public long Fee { get; set; }

	[JsonPropertyName("quoted_pickup_time")]
	public DateTimeOffset? QuotedPickupTime { get; set; }

	[JsonPropertyName("dropoff_address")]
	public Address? DropoffAddress { get; set; }

	[JsonPropertyName("allow_unattended_delivery")]
	public bool AllowUnattendedDelivery { get; set; }

	[JsonPropertyName("tip")]
	public long Tip { get; set; }

	[JsonPropertyName("team_lift_required")]
	public bool TeamLiftRequired { get; set; }

	[JsonPropertyName("external_store_id")]
	public string? ExternalStoreId { get; set; }

	[JsonPropertyName("pickup_instructions")]
	public string? PickupInstructions { get; set; }

	[JsonPropertyName("dasher")]
	public Dasher? Dasher { get; set; }

	[JsonPropertyName("status")]
	public string? Status { get; set; }

	[JsonPropertyName("quoted_delivery_time")]
	public DateTimeOffset? QuotedDeliveryTime { get; set; }

	[JsonPropertyName("actual_pickup_time")]
	public DateTimeOffset? ActualPickupTime { get; set; }

	[JsonPropertyName("signature_required")]
	public bool SignatureRequired { get; set; }

	[JsonPropertyName("pickup_address")]
	public Address? PickupAddress { get; set; }

	[JsonPropertyName("barcode_scanning_required")]
	public bool BarcodeScanningRequired { get; set; }

	[JsonPropertyName("delivery_tracking_url")]
	public string? DeliveryTrackingUrl { get; set; }

	[JsonPropertyName("external_delivery_id")]
	public string? ExternalDeliveryId { get; set; }

	[JsonPropertyName("customer")]
	public Customer? Customer { get; set; }

	[JsonPropertyName("order_value")]
	public long OrderValue { get; set; }

	[JsonPropertyName("items")]
	public List<Item>? Items { get; set; }

	[JsonPropertyName("dropoff_instructions")]
	public string? DropoffInstructions { get; set; }

	[JsonPropertyName("actual_delivery_time")]
	public DateTimeOffset? ActualDeliveryTime { get; set; }

	[JsonPropertyName("signature_image_url")]
	public string? SignatureImageUrl { get; set; }

	[JsonPropertyName("quantity")]
	public long Quantity { get; set; }

	[JsonPropertyName("delivery_verification_image_url")]
	public string? DeliveryVerificationImageUrl { get; set; }

	[JsonPropertyName("pickup_verification_image_url")]
	public string? PickupVerificationImageUrl { get; set; }
}
