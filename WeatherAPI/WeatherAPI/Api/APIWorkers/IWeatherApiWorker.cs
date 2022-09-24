using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI
{
    interface IWeatherApiWorker
    {
        public WeatherForecast GetData(IWeatherApiOptions options);
    }
}
