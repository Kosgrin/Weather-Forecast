using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weatherman.Models.OpenWeatherMapApiModel
{
	public class WeatherResponseForecast
	{
		public CityName City { get; set; }
		public Coord Coord { get; set; }
		public string Country { get; set;}
		public Weather Weather { get; set; }
		public string Base { get; set; }
		public Main Main { get; set; }
		public int Visibility { get; set; }
		public int Timezone { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public int Cod { get; set; }
		public List<List> List { get; set; }
	}
}
