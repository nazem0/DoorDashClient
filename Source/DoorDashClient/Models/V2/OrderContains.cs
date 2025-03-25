using System.Text.Json.Serialization;

namespace DoorDashClient.Models.V2
{
	/// <summary>
	/// Bool flags to tell Doordash if the delivery has certain items that need special attention.
	/// </summary>
	public class OrderContains
	{
		/// <summary>
		/// Mark as true if the delivery contains alcohol.
		/// </summary>
		/// <remarks>Some states will not allow alcohol delivery so be sure to account for this in your code such as catching exceptions.</remarks>
		[JsonPropertyName("alcohol")]
		public bool Alcohol { get; set; }

		/// <summary>
		/// Mark as true if the delivery contains pharmacy items.
		/// </summary>
		[JsonPropertyName("pharmacy_items")]
		public bool PharmacyItems { get; set; }

		/// <summary>
		/// Mark as true if the delivery contains age-restricted pharmacy items.
		/// </summary>
		[JsonPropertyName("age_restricted_pharmacy_items")]
		public bool AgeRestrictedPharmacyItems { get; set; }

		/// <summary>
		/// Mark as true if the delivery contains tobacco products.
		/// </summary>
		[JsonPropertyName("tobacco")]
		public bool Tobacco { get; set; }

		/// <summary>
		/// Mark as true if the delivery contains hemp-based products.
		/// </summary>
		[JsonPropertyName("hemp")]
		public bool Hemp { get; set; }

		/// <summary>
		/// Mark as true if the delivery contains over-the-counter (OTC) medication.
		/// </summary>
		[JsonPropertyName("otc")]
		public bool Otc { get; set; }
	}
}
