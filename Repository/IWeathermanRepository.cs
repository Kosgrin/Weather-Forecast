using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weatherman.Models.OpenWeatherMapApiModel;

namespace Weatherman.Repository
{
	public interface IWeathermanRepository
	{
		WeatherResponse GetForecast(string city);
		WeatherResponseForecast Get5dayForecast(string city);
	}
}
