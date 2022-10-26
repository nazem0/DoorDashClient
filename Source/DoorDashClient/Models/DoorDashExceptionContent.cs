using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DoorDashClient.Models;

/// <summary>
/// If a Doordash request fails, this represents errors in the fields returned.
/// </summary>
public record DoorDashExceptionContent
{
	[JsonPropertyName("field_errors")]
	public List<FieldError>? FieldErrors { get; set; }
}

/// <summary>
/// A field error showing the bad field and the error that took place.
/// </summary>
public record FieldError
{
	[JsonPropertyName("field")]
	public string? Field { get; set; }
	[JsonPropertyName("error")]
	public string? Error { get; set; }
}

