namespace DoorDashClient.Models.Classic;

public partial class TokenResponse
{
	public string? Token { get; set; }

	public string? DashboardLocation { get; set; }

	public string? AllowedLocations { get; set; }

	public string? AllowedWebsites { get; set; }

	public string? AllowedOrganizations { get; set; }

	public bool IsAdministrator { get; set; }

	public bool UsesDoorDashClassic { get; set; }

	public bool UsesDoorDashDrive { get; set; }

	public bool UsesDoorDashAsAServiceOnly { get; set; }
}
