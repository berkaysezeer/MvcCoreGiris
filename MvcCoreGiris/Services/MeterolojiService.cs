using MvcCoreGiris.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreGiris.Services
{
    public class MeterolojiService : IWeatherService
    {
        public decimal Temperature(string cityName)
        {
            switch (cityName.ToLower())
            {
                case "ankara":
                    return 33;
                case "konya":
                    return 35;
                default:
                    return 32;
            }
        }
    }
}
