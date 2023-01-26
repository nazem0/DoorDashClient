using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.V2
{
	public class DriveApiRequest
	{
		/// <summary>
		/// Required - Your external delivery ID - a <see cref="Guid"/> string is recommended.
		/// </summary>
		[JsonPropertyName("external_delivery_id")]
		[Required]
		public string ExternalDeliveryId { get; set; }
		/// <summary>
		/// Required - the locale for which the delivery is based in. Default is en-US.
		/// </summary>
		[JsonPropertyName("locale")]
		[Required]
		public string Locale { get; set; } = "en-US";
		/// <summary>
		/// Required - The comma separated address for which the delivery items will be picked up at.
		/// Example: 123 S Easy St, City, ST 55555
		/// </summary>
		/// <remarks>Do not use with PickupExternalBusinessId or PickupExternalStoreId.</remarks>
		[JsonPropertyName("pickup_address")]
		public string PickupAddress { get; set; }
		/// <summary>
		/// Required - The name of the business where the items will be picked up at.
		/// </summary>
		/// <remarks>Do not use with PickupExternalBusinessId or PickupExternalStoreId.</remarks>
		[JsonPropertyName("pickup_business_name")]
		public string PickupBusinessName { get; set; }
		/// <summary>
		/// Required - The phone number of the business where the items will be picked up at.
		/// </summary>
		/// <remarks>Do not use with PickupExternalBusinessId or PickupExternalStoreId.</remarks>
		[JsonPropertyName("pickup_phone_number")]
		public string PickupPhoneNumber { get; set; }
		/// <summary>
		/// Optional - Pickup instructions for the Dasher.
		/// </summary>
		[JsonPropertyName("pickup_instructions")]
		public string PickupInstructions { get; set; }
		/// <summary>
		/// A reference tag for the pickup, usually an order number of some kind.
		/// </summary>
		[JsonPropertyName("pickup_reference_tag")]
		public string PickupReferenceTag { get; set; }
		/// <summary>
		/// Optional - If you have a business made, you can use your ID instead of putting in the name and number.
		/// </summary>
		/// <remarks>Use this OR the other pickup fields such as name, number, address. Do not use both.</remarks>
		[JsonPropertyName("pickup_external_business_id")]
		public string PickupExternalBusinessId { get; set; }
		/// <summary>
		/// Optional - If you have a store made under your business, you can use this ID and the store details will be filled in automatically.
		/// </summary>
		/// <remarks>Use this OR the other pickup fields such as name, number, address. Do not use both.</remarks>
		[JsonPropertyName("pickup_external_store_id")]
		public string PickupExternalStoreId { get; set; }
		/// <summary>
		/// Required - the comma separated address of the person or business that is receiving the items.
		/// </summary>
		[JsonPropertyName("dropoff_address")]
		[Required]
		public string DropoffAddress { get; set; }
		/// <summary>
		/// Optional - the name of the business that is receiving the items.
		/// </summary>
		/// <remarks>Use if the dropoff location is a business.</remarks>
		[JsonPropertyName("dropoff_business_name")]
		public string DropoffBusinessName { get; set; }
		/// <summary>
		/// Required - the phone number of the person or business that is receiving the items.
		/// </summary>
		[JsonPropertyName("dropoff_phone_number")]
		[Required]
		public string DropoffPhoneNumber { get; set; }
		/// <summary>
		/// Optional - Dropoff/delivery instructions for the Dasher.
		/// </summary>
		[JsonPropertyName("dropoff_instructions")]
		public string DropoffInstructions { get; set; }
		/// <summary>
		/// Required - the given name of the person receiving the items.
		/// </summary>
		[JsonPropertyName("dropoff_contact_given_name")]
		[Required]
		public string DropoffContactGivenName { get; set; }
		/// <summary>
		/// Required - the family name of the person receiving the items.
		/// </summary>
		[JsonPropertyName("dropoff_contact_family_name")]
		[Required]
		public string DropoffContactFamilyName { get; set; }
		/// <summary>
		/// Required - sends text notifications on delivery status to the person receiving the items. Default is true.
		/// </summary>
		[JsonPropertyName("dropoff_contact_send_notifications")]
		[Required]
		public bool DropoffContactSendNotifications { get; set; } = true;
		/// <summary>
		/// Required - the order total as cents as an integer. For example, 3.00 would be 300 here.
		/// </summary>
		[JsonPropertyName("order_value")]
		[Required]
		public int OrderValue { get; set; }
		/// <summary>
		/// Required - the 3 character ISO code for currency used. Default is USD.
		/// </summary>
		[JsonPropertyName("currency")]
		[Required]
		public string Currency { get; set; } = "USD";
		/// <summary>
		/// Required - the requested dropoff time in ISO 8601 format (YYYY-MM-DDTHH:MM:SSZ)
		/// </summary>
		[JsonPropertyName("dropoff_time")]
		[Required]
		public string DropoffTime { get; set; }
		/// <summary>
		/// Required - the requested pickup time in ISO 8601 format (YYYY-MM-DDTHH:MM:SSZ)
		/// </summary>
		[JsonPropertyName("pickup_time")]
		[Required]
		public string PickupTime { get; set; }
		/// <summary>
		/// Optional - request the dasher to make a contactless delivery. Default is false.
		/// </summary>
		[JsonPropertyName("contactless_dropoff")]
		public bool ContactlessDropoff { get; set; } = false;
		/// <summary>
		/// Required - the action taken by the Dasher is delivery failed or is not possible. Default is return_to_pickup.
		/// </summary>
		/// <remarks>Options: dispose (dispose of items), return_to_pickup (return items to store)</remarks>
		[JsonPropertyName("action_if_undeliverable")]
		[Required]
		public string ActionIfUndeliverable { get; set; } = "return_to_pickup";
		/// <summary>
		/// Required - the tip for the dasher in cents as an integer. For example, 3.00 would be 300 here.
		/// </summary>
		/// <remarks>Must first default to be 20% of the total in your integration.</remarks>
		[JsonPropertyName("tip")]
		[Required]
		public int Tip { get; set; }
		/// <summary>
		/// Required - flags to tell Doordash if the delivery has certain items that need special attention such as alcohol.
		/// </summary>
		[JsonPropertyName("order_contains")]
		[Required]
		public OrderContains OrderContains { get; set; }

	}
}
