using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;
using CodeTheWay.Web.Ui.Services;


namespace CodeTheWay.Web.Ui.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private AppDbContext AppDbContext;

        public WeatherRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }

        public async Task<List<Weather>> GetWeathers()
        {
            return await AppDbContext.Weathers.ToListAsync();
        }

        public async Task<Weather> GetWeather(Guid id)
        {
            return await AppDbContext.Weathers.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Weather> Delete(Weather model)
        {
            AppDbContext.Weathers.Remove(model);
            await AppDbContext.SaveChangesAsync();
            return model;
        }

    }
}
