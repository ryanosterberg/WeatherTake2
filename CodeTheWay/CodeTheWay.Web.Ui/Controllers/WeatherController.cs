using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using CodeTheWay.Web.Ui.Models.MyViewModels;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class WeatherController : Controller
    {
        private IWeatherService WeatherService;

        public WeatherController(IWeatherService weatherService)
        {
            this.WeatherService = weatherService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View(new WeatherViewModel());
        }
        public async Task<IActionResult> Register(WeatherViewModel model)
        {
            if (ModelState.IsValid)
            {
                Weather weather = new Weather()
                {
                    Id = model.Id,
                    HighTemp = model.HighTemp,
                    LowTemp = model.LowTemp,
                    AvgWindSpeed = model.AvgWindSpeed,
                    Date = model.Date,
                    TotalPrecipitation = model.TotalPrecipitation
                };
                var varweather = await WeatherService.CreateWeather(weather);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
