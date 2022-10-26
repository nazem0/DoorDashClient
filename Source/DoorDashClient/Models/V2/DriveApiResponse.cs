using System;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.V2;
public class DriveApiResponse
{
	/// <summary>
	/// Your external delivery ID.
	/// </summary>
	[JsonPropertyName("external_delivery_id")]
	public string? ExternalDeliveryId { get; set; }
	/// <summary>
	/// The locale for which the delivery is based in.
	/// </summary>
	[JsonPropertyName("locale")]
	public string? Locale { get; set; }
	/// <summary>
	/// The comma separated address for which the delivery items will be/are picked up at, if provided during delivery creation.
	/// Example: 123 S Easy St, City, ST 55555
	/// </summary>
	[JsonPropertyName("pickup_address")]
	public string? PickupAddress { get; set; }
	/// <summary>
	/// The name of the business for which the delivery items will be/are picked up at, if provided during delivery creation.
	/// </summary>
	[JsonPropertyName("pickup_business_name")]
	public string? PickupBusinessName { get; set; }
	/// <summary>
	/// The phone number of the business for which the delivery items will be/are picked up at, if provided during delivery creation.
	/// </summary>
	[JsonPropertyName("pickup_phone_number")]
	public string? PickupPhoneNumber { get; set; }
	/// <summary>
	/// Pickup instructions for the Dasher if they were provided.
	/// </summary>
	[JsonPropertyName("pickup_instructions")]
	public string? PickupInstructions { get; set; }
	/// <summary>
	/// Reference tag for the pickup if provided.
	/// </summary>
	[JsonPropertyName("pickup_reference_tag")]
	public string? PickupReferenceTag { get; set; }
	/// <summary>
	/// The external business ID if provided.
	/// </summary>
	[JsonPropertyName("pickup_external_business_id")]
	public string? PickupExternalBusinessId { get; set; }
	/// <summary>
	/// The external store ID if provided.
	/// </summary>
	[JsonPropertyName("pickup_external_store_id")]
	public string? PickupExternalStoreId { get; set; }
	/// <summary>
	/// The comma separated address of the person or business receiving the items.
	/// Example: 123 S Easy St, City, ST 55555
	/// </summary>
	[JsonPropertyName("dropoff_address")]
	public string? DropoffAddress { get; set; }
	/// <summary>
	/// The name of the business receiving the items, if provided during delivery creation.
	/// Example: 123 S Easy St, City, ST 55555
	/// </summary>
	[JsonPropertyName("dropoff_business_name")]
	public string? DropoffBusinessName { get; set; }
	/// <summary>
	/// The phone number of the person or business receiving the items.
	/// </summary>
	[JsonPropertyName("dropoff_phone_number")]
	public string? DropoffPhoneNumber { get; set; }
	/// <summary>
	/// Delivery/dropoff instructions for the Dasher, if provided during delivery creation.
	/// </summary>
	[JsonPropertyName("dropoff_instructions")]
	public string? DropoffInstructions { get; set; }
	/// <summary>
	/// The given name of the person receiving the items.
	/// </summary>
	[JsonPropertyName("dropoff_contact_given_name")]
	public string? DropoffContactGivenName { get; set; }
	/// <summary>
	/// The family name of the person receiving the items.
	/// </summary>
	[JsonPropertyName("dropoff_contact_family_name")]
	public string? DropoffContactFamilyName { get; set; }
	/// <summary>
	/// Denotes if the person or business receiving the delivery is getting text notifications on delivery status.
	/// </summary>
	[JsonPropertyName("dropoff_contact_send_notifications")]
	public bool DropoffContactSendNotifications { get; set; }
	/// <summary>
	/// The order total in cents.
	/// </summary>
	[JsonPropertyName("order_value")]
	public int OrderValue { get; set; }
	/// <summary>
	/// The currency.
	/// </summary>
	[JsonPropertyName("currency")]
	public string Currency { get; set; } = "USD";
	/// <summary>
	/// The status of the delivery.
	/// </summary>
	/// <remarks>Options: quote, created, confirmed, enroute_to_pickup,
	/// arrived_at_pickup, picked_up, enroute_to_dropoff, arrived_at_dropoff,
	/// delivered, enroute_to_return, arrived_at_return, returned, cancelled </remarks>
	[JsonPropertyName("delivery_status")]
	public string? DeliveryStatus { get; set; }
	/// <summary>
	/// The reason the delivery was cancelled, if any.
	/// </summary>
	[JsonPropertyName("cancellation_reason")]
	public string? CancellationReason { get; set; }
	/// <summary>
	/// The date and time when the delivery was updated.
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset? UpdatedAt { get; set; }
	/// <summary>
	/// The date and time when the delivery is estimated to be picked up.
	/// </summary>
	[JsonPropertyName("pickup_time_estimated")]
	public DateTimeOffset EstimatedPickupTime { get; set; }
	/// <summary>
	/// The date and time when the delivery has been picked up.
	/// </summary>
	[JsonPropertyName("pickup_time_actual")]
	public DateTimeOffset? ActualPickupTime { get; set; }
	/// <summary>
	/// The date and time when the delivery is estimated to be done.
	/// </summary>
	[JsonPropertyName("dropoff_time_estimated")]
	public DateTimeOffset EstimatedDeliveryTime { get; set; }
	/// <summary>
	/// The date and time when the delivery is done.
	/// </summary>
	[JsonPropertyName("dropoff_time_actual")]
	public DateTimeOffset? ActualDeliveryTime { get; set; }
	/// <summary>
	/// If delivery fails and the return action was to return to store, this is the date and time when the delivery is estimated to be returned to the store.
	/// </summary>
	[JsonPropertyName("return_time_estimated")]
	public DateTimeOffset? EstimatedReturnTime { get; set; }
	/// <summary>
	/// If delivery fails and the return action was to return to store, this is the date and time when the delivery was returned to the store.
	/// </summary>
	[JsonPropertyName("return_time_actual")]
	public DateTimeOffset? ActualReturnTime { get; set; }
	/// <summary>
	/// The comma separated address where the items will be returned.
	/// </summary>
	[JsonPropertyName("return_address")]
	public string? ReturnAddress { get; set; }
	/// <summary>
	/// The delivery fee in cents.
	/// </summary>
	[JsonPropertyName("fee")]
	public int Fee { get; set; }
	/// <summary>
	/// A unique value to use when requesting support on a delivery.
	/// </summary>
	[JsonPropertyName("support_reference")]
	public string? SupportReference { get; set; }
	/// <summary>
	/// The tracking URL for the delivery.
	/// </summary>
	[JsonPropertyName("tracking_url")]
	public string? TrackingUrl { get; set; }
	/// <summary>
	/// The URL of the image the Dasher took to verify delivery dropoff.
	/// </summary>
	[JsonPropertyName("dropoff_verification_image_url")]
	public string? DropoffVerificationImageUrl { get; set; }
	/// <summary>
	/// The URL of the image the Dasher took to verify pickup.
	/// </summary>
	[JsonPropertyName("pickup_verification_image_url")]
	public string? PickupVerificationImageUrl { get; set; }
	/// <summary>
	/// Flag to specify if the delivery should be contactless.
	/// </summary>
	[JsonPropertyName("contactless_dropoff")]
	public bool ContactlessDropoff { get; set; }
	/// <summary>
	/// An action to tell the Dasher what to do on a failed delivery.
	/// </summary>
	[JsonPropertyName("action_if_undeliverable")]
	public string ActionIfUndeliverable { get; set; } = "return_to_pickup";
	/// <summary>
	/// The Dasher tip in cents.
	/// </summary>
	[JsonPropertyName("tip")]
	public int Tip { get; set; }
	/// <summary>
	/// Flags to tell Doordash if the delivery has certain items that need special attention.
	/// </summary>
	[JsonPropertyName("order_contains")]
	public OrderContains? OrderContains { get; set; }
	/// <summary>
	/// The name of the Dasher.
	/// </summary>
	[JsonPropertyName("dasher_name")]
	public string? DasherName { get; set; }
	/// <summary>
	/// The phone number of the Dasher for the dropoff contact to use, and is masked.
	/// </summary>
	[JsonPropertyName("dasher_dropoff_phone_number")]
	public string? DasherDropoffPhoneNumber { get; set; }
	/// <summary>
	/// The phone number of the Dasher for the pickup contact to use, and is masked.
	/// </summary>
	[JsonPropertyName("dasher_pickup_phone_number")]
	public string? DasherPickupPhoneNumber { get; set; }
	/// <summary>
	/// The latitude/longitude location of the Dasher.
	/// </summary>
	[JsonPropertyName("dasher_location")]
	public Location? DasherLocation { get; set; }
	/// <summary>
	/// The Dasher's vehicle make.
	/// </summary>
	[JsonPropertyName("dasher_vehicle_make")]
	public string? DasherVehicleMake { get; set; }
	/// <summary>
	/// The Dasher's vehicle model.
	/// </summary>
	[JsonPropertyName("dasher_vehicle_odel")]
	public string? DasherVehicleModel { get; set; }
	/// <summary>
	/// The Dasher's vehicle year.
	/// </summary>
	[JsonPropertyName("dasher_vehicle_year")]
	public string? DasherVehicleYear { get; set; }
}

