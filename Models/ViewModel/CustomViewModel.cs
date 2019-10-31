using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weatherman.Models.OpenWeatherMapApiModel;
using Weatherman.Models.WeathermanAppModel;

namespace Weatherman.Models.ViewModel
{
	public class CustomViewModel
	{
		public City City { get; set; }
		public WeatherResponseForecast CityForecast { get; set; }
	}
}
