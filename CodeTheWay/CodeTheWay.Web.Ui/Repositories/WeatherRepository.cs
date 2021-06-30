using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private AppDbContext AppDbContext;

        public WeatherRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }
        public async Task<Weather> Create(Weather weather)
        {
            var result = await this.AppDbContext.AddAsync(weather);
            await this.AppDbContext.SaveChangesAsync();

            return result.Entity;
        }
        public async Task<Weather> Update(Weather model)
        {
            var result = AppDbContext.Weathers.Update(model);
            await AppDbContext.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<List<Weather>> GetWeathers()
        {
            return await this.AppDbContext.Weathers.ToListAsync();
        }
    }
}
