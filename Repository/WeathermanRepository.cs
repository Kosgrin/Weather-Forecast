
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Weatherman.Config;
using Weatherman.Models.OpenWeatherMapApiModel;

namespace Weatherman.Repository
{
	public class WeathermanRepository : IWeathermanRepository
	{
		WeatherResponse IWeathermanRepository.GetForecast(string city)
		{
			string IDOWeather = Key.OPEN_WEATHER_APPID;
			// Connection String
			var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={IDOWeather}&lang=ru");
			var request = new RestRequest(Method.GET);
			IRestResponse response = client.Execute(request);

			if (response.IsSuccessful)
			{
				// Deserialize the string content into JToken object
				var content = JsonConvert.DeserializeObject<JToken>(response.Content);

				// Deserialize the JToken object into our WeatherResponse Class
				return content.ToObject<WeatherResponse>();
			}
			return null;
		}

		WeatherResponseForecast IWeathermanRepository.Get5dayForecast(string city)
		{
			string IDOWeather = Key.OPEN_WEATHER_APPID;

			var client = new RestClient($"http://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&APPID={IDOWeather}&lang=ru");
			var request = new RestRequest(Method.GET);
			IRestResponse response = client.Execute(request);

			if (response.IsSuccessful)
			{
				// Deserialize the string content into JToken object
				var content = JsonConvert.DeserializeObject<JToken>(response.Content);

				// Deserialize the JToken object into our WeatherResponse Class
				return content.ToObject<WeatherResponseForecast>();
			}
			return null;
		}
	}
}
