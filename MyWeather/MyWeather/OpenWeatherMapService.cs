using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyWeather
{
    class OpenWeatherMapService
    {
        private const string APIUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&units=imperial";
        public async Task<WeatherRoot> GetWeather(string location)
        {
            var client = new HttpClient();
            var url = string.Format(APIUrl, location);
            var json = await client.GetStringAsync(url);

            if (string.IsNullOrWhiteSpace(json))
                return null;

            return JsonConvert.DeserializeObject<WeatherRoot>(json);
        }
    }
}
