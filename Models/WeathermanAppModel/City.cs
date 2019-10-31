using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;


namespace Weatherman.Models.WeathermanAppModel
{
	public class City
	{
		[Display(Name = "Город:")]
		public string Name { get; set; }

		[Display(Name = "Температура:")]
		public float Temperature { get; set; }

		[Display(Name = "Влажность")]
		public int Humidity { get; set; }

		[Display(Name = "Атмосферное давление:")]
		public int Pressure { get; set; }

		[Display(Name = "Скорость ветра:")]
		public float Wind { get; set; }

		[Display(Name = "Погодные условия:")]
		public string Weather { get; set; }
		public string Image { get; set; }  

		
		
	}
}
