using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weatherman.Models.OpenWeatherMapApiModel
{
	public class List
	{
		public int Dt { get; set; }
		public Main Main { get; set; }
		public List<Weather> Weather { get; set; }
		public Wind Wind { get; set; }
		public Clouds Clouds { get; set; }
		public Sys Sys { get; set; }
		public DateTime Dt_txt { get; set; }




	}
}
