using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreGiris.Interfaces
{
    public interface IWeatherService
    {
        public decimal Temperature(string cityName);

    }
}
