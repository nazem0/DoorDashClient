using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic;

public partial class DeliveryRequest
{
	[JsonPropertyName("pickup_address")]
	public Address PickupAddress { get; set; }

	[JsonPropertyName("pickup_phone_number")]
	public string PickupPhoneNumber { get; set; }

	[JsonPropertyName("dropoff_address")]
	public Address DropoffAddress { get; set; }

	[JsonPropertyName("customer")]
	public Customer Customer { get; set; }

	[JsonPropertyName("order_value")]
	public long OrderValue { get; set; }

	[JsonPropertyName("delivery_time")]
	public string DeliveryTime { get; set; }

	[JsonPropertyName("items")]
	public List<Item> Items { get; set; }

	[JsonPropertyName("pickup_business_name")]
	public string PickupBusinessName { get; set; }

	[JsonPropertyName("external_store_id")]
	public string ExternalStoreId { get; set; }

	[JsonPropertyName("external_business_name")]
	public string ExternalBusinessName { get; set; }

	[JsonPropertyName("external_delivery_id")]
	public string ExternalDeliveryId { get; set; }

	[JsonPropertyName("pickup_instructions")]
	public string PickupInstructions { get; set; }

	[JsonPropertyName("dropoff_instructions")]
	public string DropoffInstructions { get; set; }

	[JsonPropertyName("tip")]
	public long Tip { get; set; }

	[JsonPropertyName("contains_alcohol")]
	public bool ContainsAlcohol { get; set; }

	[JsonPropertyName("num_items")]
	public long NumItems { get; set; }
}
