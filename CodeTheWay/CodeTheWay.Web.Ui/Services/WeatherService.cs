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
        public async Task<Weather> Create(Weather weather)
        {
            return await this.WeatherRepo.Create(weather);
        }
        public async Task<Weather> Update(Weather weather)
        {
            return await WeatherRepo.Update(weather);
        }


    }
}
