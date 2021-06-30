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
        public async Task<IActionResult> Update(Weather model)
        {
            if (ModelState.IsValid)
            {
                if(model.AvgWindSpeed > 0)
                {
                    Weather list = new Weather()
                    {
                        Id = model.Id,
                        LowTemp = model.LowTemp,
                        HighTemp = model.HighTemp,
                        AvgWindSpeed = model.AvgWindSpeed,
                        Date = model.Date,
                        TotalPrecipitation = model.TotalPrecipitation
                    };
                    var weather = await WeatherService.Update(list);
                }
                return RedirectToAction("index");
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var weather = await WeatherService.GetWeather(id);
            WeatherViewModel model = new WeatherViewModel()
            {
                Id = weather.Id,
                LowTemp = weather.LowTemp,
                HighTemp = weather.HighTemp,
                AvgWindSpeed = weather.AvgWindSpeed,
                Date = weather.Date,
                TotalPrecipitation = weather.TotalPrecipitation
            };
            return View(model);
        }
    }
}
