using System;
using System.IO;
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
            string jsonString;
            jsonString = JsonSerializer.Serialize(weatherForecast);
            SaveWeatherForcast("WeatherForecast.txt", weatherForecast);
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
