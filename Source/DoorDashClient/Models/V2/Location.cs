using System.Text.Json.Serialization;

namespace DoorDashClient.Models.V2
{
	/// <summary>
	/// Represents a latitude/longitude location marker.
	/// </summary>
	public class Location
	{
		/// <summary>
		/// The latitude.
		/// </summary>
		[JsonPropertyName("lat")]
		public float Latitude { get; set; }
		/// <summary>
		/// The longitude.
		/// </summary>
		[JsonPropertyName("lng")]
		public float Longitude { get; set; }
	}
}