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
        public HourlyForecast HourlyForecast { get; } = new HourlyForecast();

        public MainViewModel()
        {
        }
    }
}
