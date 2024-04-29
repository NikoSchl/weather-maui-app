using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WeatherApp.Collections;
using WeatherApp.Models;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WeatherApp.Helpers;

namespace WeatherApp.ViewModels
{
    public class MainViewModel
    {
        // Objekt mit den Eigenschaften (Temperatur, Date und enum Condition)
        public HourlyForecast HourlyForecast { get; } = HourlyForecast.GenerateHourlyForecastForMainPage();

        // Objekt mit den Eigenschaften (Windspeed und enum Winddirection)
        public WindForecast WindForecast { get; } = WindForecast.GenerateWindForecast();
    }
}
