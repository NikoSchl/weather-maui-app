using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WeatherApp.Collections;
using WeatherApp.Models;
using System.Threading.Tasks;

namespace WeatherApp.ViewModels
{
    public class MainViewModel
    {
        Random Random { get; set; } = new Random();

        public HourlyForecast HourlyForecast { get; } = new HourlyForecast();

        public MainViewModel()
        {
            WindForecast windForecast = new WindForecast();
            windForecast.Windspeed = Random.Next(1, 80);
        }
    }
}
