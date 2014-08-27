using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyWeather
{
	public class Coord
	{
		[JsonProperty("lon")]
		public double Longitude { get; set; }

		[JsonProperty("lat")]
		public double Latitude { get; set; }
	}

	public class Sys
	{
		[JsonProperty("message")]
		public double message { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("sunrise")]
		public int Sunrise { get; set; }

		[JsonProperty("sunset")]
		public int Sunset { get; set; }
	}

	public class Weather
	{
		public int id { get; set; }
		[JsonProperty("main")]
		public string Main { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}

	public class Main
	{
		[JsonProperty("temp")]
		public double Temp { get; set; }

		[JsonProperty("pressure")]
		public int Pressure { get; set; }

		[JsonProperty("temp_min")]
		public double MinimumTemp { get; set; }

		[JsonProperty("temp_max")]
		public double MaximumTemp { get; set; }

		[JsonProperty("humidity")]
		public int Humidity { get; set; }
	}

	public class Wind
	{
		[JsonProperty("speed")]
		public double Speed { get; set; }
		[JsonProperty("gust")]
		public double Gust { get; set; }

	}

	public class Clouds
	{
		[JsonProperty("all")]
		public int All { get; set; }
	}

	public class WeatherRoot
	{
		[JsonProperty("coord")]
		public Coord Coordinates { get; set; }
		[JsonProperty("sys")]
		public Sys System { get; set; }

		[JsonProperty("weather")]
		public List<Weather> Weather { get; set; }

		[JsonProperty("@base")]
		public string Base { get; set; }

		[JsonProperty("main")]
		public Main MainWeather { get; set; }

		[JsonProperty("wind")]
		public Wind Wind { get; set; }

		[JsonProperty("clouds")]
		public Clouds Clouds { get; set; }

		public int dt { get; set; }
		public int id { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		public int cod { get; set; }
	}
}

