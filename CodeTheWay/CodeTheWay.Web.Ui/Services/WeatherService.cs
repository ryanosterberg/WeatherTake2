﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Repositories;

namespace CodeTheWay.Web.Ui.Services
{
    public class WeatherService : IWeatherService
    {
        private IWeatherRepository WeatherRepo;

        public WeatherService(AppDbContext dbContext)
        {
            this.WeatherRepo = new WeatherRepository(dbContext);
        }
         public async Task<List<Weather>> GetWeathers()
        {
            return await this.WeatherRepo.GetWeathers();
        }

        public async Task<Weather> GetWeather(Guid id)
        {
            return await this.WeatherRepo.GetWeather(id);
        }

        public async Task<Weather> Delete(Weather weather)
        {
            return await WeatherRepo.Delete(weather);
        }

    }
}
