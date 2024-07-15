namespace WeatherGuessingBackend
{
    public class City
    {
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        private static List<City> cityList = new List<City>             {
                new City { Name = "Zürich", Latitude = 47.3769f, Longitude = 8.5417f },
                new City { Name = "New York", Latitude = 40.7128f, Longitude = -74.0060f },
                new City { Name = "Tokyo", Latitude = 35.6895f, Longitude = 139.6917f },
                new City { Name = "Sydney", Latitude = -33.8688f, Longitude = 151.2093f },
                new City { Name = "London", Latitude = 51.5074f, Longitude = -0.1278f },
                new City { Name = "Paris", Latitude = 48.8566f, Longitude = 2.3522f },
                new City { Name = "Berlin", Latitude = 52.5200f, Longitude = 13.4050f },
                new City { Name = "Moscow", Latitude = 55.7558f, Longitude = 37.6173f },
                new City { Name = "Beijing", Latitude = 39.9042f, Longitude = 116.4074f },
                new City { Name = "Delhi", Latitude = 28.6139f, Longitude = 77.2090f },
                new City { Name = "São Paulo", Latitude = -23.5505f, Longitude = -46.6333f },
                new City { Name = "Mexico City", Latitude = 19.4326f, Longitude = -99.1332f },
                new City { Name = "Cairo", Latitude = 30.0444f, Longitude = 31.2357f },
                new City { Name = "Buenos Aires", Latitude = -34.6037f, Longitude = -58.3816f },
                new City { Name = "Johannesburg", Latitude = -26.2041f, Longitude = 28.0473f },
                new City { Name = "Bangkok", Latitude = 13.7563f, Longitude = 100.5018f },
                new City { Name = "Hong Kong", Latitude = 22.3193f, Longitude = 114.1694f },
                new City { Name = "Singapore", Latitude = 1.3521f, Longitude = 103.8198f },
                new City { Name = "Los Angeles", Latitude = 34.0522f, Longitude = -118.2437f },
                new City { Name = "Chicago", Latitude = 41.8781f, Longitude = -87.6298f },
                new City { Name = "Toronto", Latitude = 43.6511f, Longitude = -79.3837f },
                new City { Name = "Vancouver", Latitude = 49.2827f, Longitude = -123.1207f },
                new City { Name = "Dubai", Latitude = 25.2048f, Longitude = 55.2708f },
                new City { Name = "Istanbul", Latitude = 41.0082f, Longitude = 28.9784f },
                new City { Name = "Seoul", Latitude = 37.5665f, Longitude = 126.9780f },
                new City { Name = "Mumbai", Latitude = 19.0760f, Longitude = 72.8777f },
                new City { Name = "Karachi", Latitude = 24.8607f, Longitude = 67.0011f },
                new City { Name = "Lagos", Latitude = 6.5244f, Longitude = 3.3792f },
                new City { Name = "Jakarta", Latitude = -6.2088f, Longitude = 106.8456f },
                new City { Name = "Manila", Latitude = 14.5995f, Longitude = 120.9842f },
                new City { Name = "Rio de Janeiro", Latitude = -22.9068f, Longitude = -43.1729f },
                new City { Name = "Lima", Latitude = -12.0464f, Longitude = -77.0428f },
                new City { Name = "Bogotá", Latitude = 4.7110f, Longitude = -74.0721f },
                new City { Name = "Santiago", Latitude = -33.4489f, Longitude = -70.6693f },
                new City { Name = "Madrid", Latitude = 40.4168f, Longitude = -3.7038f },
                new City { Name = "Rome", Latitude = 41.9028f, Longitude = 12.4964f },
                new City { Name = "Vienna", Latitude = 48.2082f, Longitude = 16.3738f },
                new City { Name = "Athens", Latitude = 37.9838f, Longitude = 23.7275f },
                new City { Name = "Warsaw", Latitude = 52.2297f, Longitude = 21.0122f },
                new City { Name = "Budapest", Latitude = 47.4979f, Longitude = 19.0402f },
                new City { Name = "Prague", Latitude = 50.0755f, Longitude = 14.4378f },
                new City { Name = "Lisbon", Latitude = 38.7223f, Longitude = -9.1393f },
                new City { Name = "Stockholm", Latitude = 59.3293f, Longitude = 18.0686f },
                new City { Name = "Oslo", Latitude = 59.9139f, Longitude = 10.7522f },
                new City { Name = "Helsinki", Latitude = 60.1699f, Longitude = 24.9384f },
                new City { Name = "Copenhagen", Latitude = 55.6761f, Longitude = 12.5683f },
                new City { Name = "Dublin", Latitude = 53.3498f, Longitude = -6.2603f },
                new City { Name = "Brussels", Latitude = 50.8503f, Longitude = 4.3517f },
                new City { Name = "Amsterdam", Latitude = 52.3676f, Longitude = 4.9041f },
                new City { Name = "Zurich", Latitude = 47.3769f, Longitude = 8.5417f },
                new City { Name = "Milan", Latitude = 45.4642f, Longitude = 9.1900f },
                new City { Name = "Munich", Latitude = 48.1351f, Longitude = 11.5820f },
                new City { Name = "Barcelona", Latitude = 41.3851f, Longitude = 2.1734f },
                new City { Name = "Frankfurt", Latitude = 50.1109f, Longitude = 8.6821f },
                new City { Name = "Hamburg", Latitude = 53.5511f, Longitude = 9.9937f },
                new City { Name = "Cologne", Latitude = 50.9375f, Longitude = 6.9603f },
                new City { Name = "Dusseldorf", Latitude = 51.2277f, Longitude = 6.7735f },
                new City { Name = "Stuttgart", Latitude = 48.7758f, Longitude = 9.1829f },
                new City { Name = "Leipzig", Latitude = 51.3397f, Longitude = 12.3731f },
                new City { Name = "Dresden", Latitude = 51.0504f, Longitude = 13.7373f },
                new City { Name = "Hanover", Latitude = 52.3759f, Longitude = 9.7320f },
                new City { Name = "Nuremberg", Latitude = 49.4521f, Longitude = 11.0767f },
                new City { Name = "Dortmund", Latitude = 51.5136f, Longitude = 7.4653f },
                new City { Name = "Essen", Latitude = 51.4556f, Longitude = 7.0116f },
                new City { Name = "Bremen", Latitude = 53.0793f, Longitude = 8.8017f },
                new City { Name = "Leeds", Latitude = 53.8008f, Longitude = -1.5491f },
                new City { Name = "Manchester", Latitude = 53.4808f, Longitude = -2.2426f },
                new City { Name = "Birmingham", Latitude = 52.4862f, Longitude = -1.8904f },
                new City { Name = "Liverpool", Latitude = 53.4084f, Longitude = -2.9916f },
                new City { Name = "Sheffield", Latitude = 53.3811f, Longitude = -1.4701f },
                new City { Name = "Bristol", Latitude = 51.4545f, Longitude = -2.5879f },
                new City { Name = "Glasgow", Latitude = 55.8642f, Longitude = -4.2518f },
                new City { Name = "Edinburgh", Latitude = 55.9533f, Longitude = -3.1883f },
                new City { Name = "Cardiff", Latitude = 51.4816f, Longitude = -3.1791f },
                new City { Name = "Belfast", Latitude = 54.5973f, Longitude = -5.9301f },
                new City { Name = "Lyon", Latitude = 45.7640f, Longitude = 4.8357f },
                new City { Name = "Marseille", Latitude = 43.2965f, Longitude = 5.3698f },
                new City { Name = "Nice", Latitude = 43.7102f, Longitude = 7.2620f },
                new City { Name = "Toulouse", Latitude = 43.6047f, Longitude = 1.4442f },
                new City { Name = "Nantes", Latitude = 47.2184f, Longitude = -1.5536f },
                new City { Name = "Strasbourg", Latitude = 48.5734f, Longitude = 7.7521f },
                new City { Name = "Montpellier", Latitude = 43.6108f, Longitude = 3.8767f },
                new City { Name = "Bordeaux", Latitude = 44.8378f, Longitude = -0.5792f },
                new City { Name = "Lille", Latitude = 50.6292f, Longitude = 3.0573f },
                new City { Name = "Rennes", Latitude = 48.1173f, Longitude = -1.6778f },
                new City { Name = "Reims", Latitude = 49.2583f, Longitude = 4.0317f },
                new City { Name = "Toulon", Latitude = 43.1242f, Longitude = 5.9280f },
                new City { Name = "Grenoble", Latitude = 45.1885f, Longitude = 5.7245f },
                new City { Name = "Dijon", Latitude = 47.3220f, Longitude = 5.0415f },
                new City { Name = "Angers", Latitude = 47.4784f, Longitude = -0.5632f },
                new City { Name = "Nimes", Latitude = 43.8367f, Longitude = 4.3601f },
                new City { Name = "Amiens", Latitude = 49.8950f, Longitude = 2.3023f }
            };


        public static City GetRandomCity()
        {
            Random random = new Random();
            int index = random.Next(cityList.Count);
            return cityList[index];
        }

        public static City GetCityByName(string cityName)
        {
            City city = cityList.Find(x => x.Name == cityName);
            return city;
        }
    }
}
