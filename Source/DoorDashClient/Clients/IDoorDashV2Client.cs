using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorDashClient.Models;
using DoorDashClient.Models.V2;
using Refit;

namespace DoorDashClient.Clients;

/// <summary>
/// A Refit interface to represent the Drive v2 API client for Doordash.
/// </summary>
public interface IDoorDashV2Client
{
	/// <summary>
	/// Requests a delivery quote.
	/// </summary>
	/// <param name="request">The request containing pickup/dropoff data, order total etc. needed to make a quote.</param>
	/// <returns>A delivery quote with details.</returns>
	[Post("/drive/v2/quotes")]
	Task<DriveApiResponse> GetDeliveryQuote([Body] DriveApiRequest request);

	/// <summary>
	/// Creates a delivery request.
	/// </summary>
	/// <param name="request">The request data (pickup/dropoff locations, order total, tip, etc.)</param>
	/// <returns>A delivery object containing details about the delivery.</returns>
	[Post("/drive/v2/deliveries")]
	Task<DriveApiResponse> CreateDelivery([Body] DriveApiRequest request);

	/// <summary>
	/// Cancels a current delivery.
	/// </summary>
	/// <param name="deliveryId">The external delivery ID</param>
	/// <returns>The delivery details with a cancellation reason.</returns>
	[Put("/drive/v2/deliveries/{deliveryId}/cancel")]
	Task<DriveApiResponse> CancelDelivery(string deliveryId);

	/// <summary>
	/// Retrieves delivery details by the external delivery ID.
	/// </summary>
	/// <param name="deliveryId">The external delivery ID</param>
	/// <returns>Delivery details.</returns>
	[Get("/drive/v2/deliveries/{deliveryId}")]
	Task<DriveApiResponse> GetDeliveryDetails(string deliveryId);
}
