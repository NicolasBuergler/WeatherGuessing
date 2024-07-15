using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WeatherGuessingBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizManagerController : ControllerBase
    {
        static HttpClient client = new HttpClient();

        private float GetRandomTemprature()
        {
            Random random = new Random();
            double min = 5;
            double max = 35;
            double randomDouble = random.NextDouble() * (max - min) + min;
            return (float)Math.Round(randomDouble, 1);
        }

        private static async Task<string> GetApiData(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        private static WeatherData GetWeatherData(City city)
        {
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={city.Latitude}&longitude={city.Longitude}&hourly=temperature_2m";
            var response = GetApiData(url).Result;

            WeatherData weatherData = JsonSerializer.Deserialize<WeatherData>(response);
            return weatherData;

        }

        [HttpGet(Name = "GetQuiz")]
        public Quiz GetQuiz()
        {
            City city = City.GetRandomCity();

            WeatherData weatherData = GetWeatherData(city);

            float currentTemprature =  weatherData.GetTemprature(DateTime.UtcNow);

            Quiz quiz = new Quiz() { City = city.Name, TempratureOptions = new float[] {GetRandomTemprature(), GetRandomTemprature(), currentTemprature}};
            quiz.TempratureOptions.Shuffle();
            return quiz;
        }

        [HttpGet("solution", Name = "GetSolution")]
        public bool GetSolution([FromQuery] float awnser, [FromQuery] string cityName)
        {
            City city = City.GetCityByName(cityName);
            WeatherData weatherData = GetWeatherData(city);

            float currentTemprature = weatherData.GetTemprature(DateTime.UtcNow);
            float lastTemprature = weatherData.GetTemprature(DateTime.UtcNow.AddHours(-1));

            if (currentTemprature == awnser || lastTemprature == awnser)
            {
                return true;
            }
            return false;
        }

    }
}
