using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Module20.SerializeAndDeserializeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherForecast = new WeatherForecast() { Date = DateTime.Now, Summary = "Good day", TemperatureCelsius = 16 };
            //string jsonString;
            //jsonString = JsonSerializer.Serialize(weatherForecast);
            //SaveWeatherForcast("WeatherForecast.txt", weatherForecast);
            //ReadJSONFromFile("WeatherForecast.txt");
            ReadPodcastToday("http://localhost:7071/api/DailyPodcast");
        }

        private static void ReadPodcastToday(string URL)
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = httpClient.GetStringAsync(URL).Result;
                Console.WriteLine(httpResponse);
            };
        }

        private static void ReadJSONFromFile(string fileName)
        {
            using (var fs = new StreamReader(fileName))
            {
                var JSONString = fs.ReadToEnd();
                var weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(JSONString);
                Console.WriteLine(weatherForecast.Summary);
            };
        }

        public static async void SaveWeatherForcast(string fileName, WeatherForecast weatherForecast)
        {
            using (FileStream fs = File.Create(fileName))
            {
                await JsonSerializer.SerializeAsync(fs, weatherForecast);
            }
        }
    }
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }

}
