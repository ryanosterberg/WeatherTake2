using System;
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
        public async Task<Weather> GetWeathers(Guid id)
        {
            return await this.WeatherRepo.GetWeathers(id);
        }
        public async Task<Weather> CreateWeather(Weather weather)
        {
            return await this.WeatherRepo.Create(weather);
        }
    }
}
