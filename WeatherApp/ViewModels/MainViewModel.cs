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
using WeatherApp.Views;

namespace WeatherApp.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        // Objekt mit den Eigenschaften (Temperatur, Date und enum Condition)
        private HourlyForecast? _hourlyForecast;

        public HourlyForecast? HourlyForecast
        {
            get => _hourlyForecast;
            private set
            {
                if(_hourlyForecast != value)
                {
                    _hourlyForecast = value;
                    OnPropertyChanged(nameof(HourlyForecast));
                }
            }
        }

        // Objekt mit den Eigenschaften (Windspeed und enum Winddirection)
        private WindForecast? _windForecast;
        public WindForecast? WindForecast
        {
            get => _windForecast;
            private set
            {
                if (_windForecast != value)
                {
                    _windForecast = value;
                    OnPropertyChanged(nameof(WindForecast));
                }
            }
        }



        public void InitializeData()
        {
            HourlyForecast = HourlyForecast.GenerateHourlyForecastForMainPage();
            WindForecast = WindForecast.GenerateWindForecast();
        }
    }
}
