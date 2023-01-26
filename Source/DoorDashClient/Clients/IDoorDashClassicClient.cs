using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Refit;
using DoorDashClient.Models.Classic;

namespace DoorDashClient.Clients;

/// <summary>
/// Refit interface for Drive Classic.
/// </summary>
public interface IDoorDashClassicClient
{
	/// <summary>
	/// Requests a delivery quote.
	/// </summary>
	/// <param name="request">The request containing pickup/dropoff data, order total etc. needed to make a quote.</param>
	/// <returns>A delivery quote with details.</returns>
	[Post("/drive/v1/estimates")]
	Task<QuoteResponse> GetDeliveryQuote([Body] QuoteRequest request);

	/// <summary>
	/// Creates a delivery request.
	/// </summary>
	/// <param name="request">The request data (pickup/dropoff locations, order total, tip, etc.)</param>
	/// <returns>A delivery object containing details about the delivery.</returns>
	[Post("/drive/v1/deliveries")]
	Task<DeliveryResponse> CreateDelivery([Body] DeliveryRequest request);

	/// <summary>
	/// Cancels a current delivery.
	/// </summary>
	/// <param name="deliveryId">The external delivery ID</param>
	/// <returns>The delivery details with a cancellation reason.</returns>
	[Put("/drive/v1/deliveries/{deliveryId}/cancel")]
	Task<CancelResponse> CancelDelivery(int deliveryId);

	/// <summary>
	/// Retrieves delivery details by the external delivery ID.
	/// </summary>
	/// <param name="deliveryId">The external delivery ID</param>
	/// <returns>Delivery details.</returns>
	[Get("/drive/v1/deliveries/{deliveryId}")]
	Task<DeliveryDetailsResponse> GetDeliveryDetails(int deliveryId);
}
