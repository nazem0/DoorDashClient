using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models.Classic
{
	public class Item
	{
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public string BarCode { get; set; }
		public int Quantity { get; set; }
		[JsonPropertyName("external_id")]
		public string ExternalId { get; set; }
		public float Volume { get; set; }
		public float Weight { get; set; }
		public int Price { get; set; }
	}
}
