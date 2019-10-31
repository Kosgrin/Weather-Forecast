using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Weatherman.Models.OpenWeatherMapApiModel;
using Weatherman.Models.ViewModel;
using Weatherman.Models.WeathermanAppModel;
using Weatherman.Repository;

namespace Weatherman.Controllers
{
	public class WeathermanAppController : Controller
    {
		private readonly IWeathermanRepository _weathermanRepository;

		public WeathermanAppController(IWeathermanRepository weathermanRepo)
		{
			_weathermanRepository = weathermanRepo;
		}

		// GET: ForecastApp/SearchCity
		public IActionResult SearchCity()
		{
			var viewModel = new SearchCity();
			return View(viewModel);
		}

		// POST: ForecastApp/SearchCity
		[HttpPost]
		public IActionResult SearchCity(SearchCity model)
		{
			
			if (ModelState.IsValid)
			{
				return RedirectToAction("City", "WeathermanApp", new { city = model.CityName });
			}
			return View(model);
		}

		// GET: ForecastApp/City
		public IActionResult City(string city)
		{
			WeatherResponse weatherResponse = _weathermanRepository.GetForecast(city);

			City viewModel = new City();
			if (weatherResponse != null)
			{
				viewModel.Name = weatherResponse.Name;
				viewModel.Humidity = weatherResponse.Main.Humidity;
				viewModel.Pressure = weatherResponse.Main.Pressure;
				viewModel.Temperature = weatherResponse.Main.Temp;
				viewModel.Weather = weatherResponse.Weather[0].Description;
				viewModel.Wind = weatherResponse.Wind.Speed;
				viewModel.Image = weatherResponse.Weather[0].Icon + ".png";
			}

			WeatherResponseForecast weatherResponseForecast = _weathermanRepository.Get5dayForecast(city);


			if (weatherResponseForecast != null)
			{
				foreach (var item in weatherResponseForecast.List)
				{

					var icon = item.Weather[0].Icon + ".png";

					item.Weather[0].Icon = icon;
				}

			}

			CustomViewModel model = new CustomViewModel { City = viewModel, CityForecast = weatherResponseForecast };

			return View(model);

		}

	}
}