using System.Text.Json.Serialization;

namespace WeatherGuessingBackend
{
    public class WeatherData
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("generationtime_ms")]
        public double GenerationTimeMs { get; set; }

        [JsonPropertyName("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        [JsonPropertyName("timezone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("timezone_abbreviation")]
        public string TimeZoneAbbreviation { get; set; }

        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }

        [JsonPropertyName("hourly_units")]
        public HourlyUnits HourlyUnits { get; set; }

        [JsonPropertyName("hourly")]
        public HourlyData Hourly { get; set; }

        public float GetTemprature(DateTime dateTime)
        {
            string TimeString = dateTime.ToString("yyyy-MM-ddTHH:00");

            int index = this.Hourly.Time.FindIndex(time => time == TimeString);

            if (index != -1)
            {
                float temperature = this.Hourly.Temperature2M[index];
                Console.WriteLine($"Die Temperatur ist: {temperature}°C");
                return temperature;
            }
            else
            {
                Console.WriteLine("Keine Temperaturdaten für die Uhrzeit gefunden.");
                return -1000;
            }
        }
    }

    public class HourlyUnits
    {
        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("temperature_2m")]
        public string Temperature2M { get; set; }
    }

    public class HourlyData
    {
        [JsonPropertyName("time")]
        public List<string> Time { get; set; }

        [JsonPropertyName("temperature_2m")]
        public List<float> Temperature2M { get; set; }
    }
}
