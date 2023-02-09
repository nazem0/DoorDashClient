using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Refit;
using DoorDashClient.Models.Classic;

namespace DoorDashClient.Clients
{
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
		/// Updates an existing delivery.
		/// </summary>
		/// <param name="deliveryId">The doordash delivery ID from CreateDelivery</param>
		/// <param name="request">The request body.</param>
		/// <returns>A delivery object with the requested updates.</returns>
		[Patch("drive/v1/deliveries/{deliveryId}")]
		Task<DeliveryResponse> UpdateDelivery(long deliveryId, [Body] UpdateDeliveryRequest request);

		/// <summary>
		/// Cancels a current delivery.
		/// </summary>
		/// <param name="deliveryId">The doordash delivery ID.</param>
		/// <returns>The delivery details with a cancellation reason.</returns>
		[Put("/drive/v1/deliveries/{deliveryId}/cancel")]
		Task<CancelResponse> CancelDelivery(long deliveryId);

		/// <summary>
		/// Retrieves delivery details by the external delivery ID.
		/// </summary>
		/// <param name="deliveryId">The doordash delivery ID</param>
		/// <param name="extra">Pass "cash_on_delivery" if you need details about that in the delivery object.</param>
		/// <returns>Delivery details.</returns>
		[Get("/drive/v1/deliveries/{deliveryId}")]
		Task<DeliveryDetailsResponse> GetDeliveryDetails(long deliveryId, [Query] string extra);
	}
}
