using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Repositories
{
    public interface IWeatherRepository
    {
        public Task<Weather> GetWeathers(Guid id);

        public Task<List<Weather>> GetWeathers();
        public Task<Weather> Create(Weather Weathers);
        public Task<Weather> Update(Weather model);
    }
}
