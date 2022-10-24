using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DoorDashClient.Models.V2;

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
}
