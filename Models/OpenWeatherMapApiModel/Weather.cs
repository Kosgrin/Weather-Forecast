using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weatherman.Models.OpenWeatherMapApiModel
{
	public class Weather
	{
		public int Id { get; set; }
		public string Main { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
	}
}
