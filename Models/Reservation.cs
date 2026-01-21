using System;
using System.Text.Json.Serialization;

namespace RestaurantBlazor.Models
{
    public class ReservationModel
    {
        // Use JsonPropertyName to map MongoDB lowercase JSON to C# Uppercase Properties
        [JsonPropertyName("_id")]
        public string? Id { get; set; }

        [JsonPropertyName("people")]
        public int People { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;

        [JsonPropertyName("time")]
        public string Time { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = "confirmed";

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}