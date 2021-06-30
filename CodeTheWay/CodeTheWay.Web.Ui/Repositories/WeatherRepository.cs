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
        public async Task<List<Weather>> GetWeathers()
        {
            return await this.AppDbContext.Weathers.ToListAsync();
        }
        public async Task<Weather> GetWeathers(Guid id)
        {
            return await this.AppDbContext.Weathers.FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<Weather> Create(Weather weathers)
        {
            var result = await this.AppDbContext.AddAsync(weathers);
            await this.AppDbContext.SaveChangesAsync();

            return result.Entity;
        }

    }
}
