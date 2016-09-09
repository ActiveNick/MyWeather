using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyWeather
{
    /// <summary>
    /// Weather Service class to call the OpenWeatherMap API
    /// For live documentation in a Xamarin Workbook on this service class, please refer to
    /// https://github.com/ActiveNick/ActiveNick-Xamarin-Workbooks/tree/master/OpenWeatherMap
    /// </summary>
    class OpenWeatherMapService
    {
        // TO DO: Get your own API key from http://openweathermap.org, don't use mine
        private const string APIKey = "b843f18aa40c5e8ad3471058123600f3";
        // URI used to get basic weather data. The API key is optional but your request may get denied
        // if you do not include one.
        private const string APIUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&units=imperial&APPID=" + APIKey;

        /// <summary>
        /// Method that returns a WeatherRoot data object for a specific location from OpenWeatherMap.org
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public async Task<WeatherRoot> GetWeather(string location)
        {
            var client = new HttpClient();
            var url = string.Format(APIUrl, location);
            var json = await client.GetStringAsync(url);

            if (string.IsNullOrWhiteSpace(json))
                return null;

            // Deserialize the JSON results into a WeatherRoot object using JSON.NET
            return JsonConvert.DeserializeObject<WeatherRoot>(json);
        }
    }
}
