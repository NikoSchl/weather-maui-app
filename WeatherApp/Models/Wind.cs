using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WeatherApp.Helpers;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Collections;

namespace WeatherApp.Models
{
    public class Wind : NotifyPropertyHelper
    {
        private string _windSpeed = string.Empty;
        private Winddirection _windDirection;

        public string Windspeed
        {
            get
            {
                return _windSpeed;
            }
            set
            {
                _windSpeed = value;
                OnPropertyChanged(nameof(Windspeed));

            }
        }

        public Winddirection WindDirection
        {
            get
            {
                return _windDirection;
            }
            set
            {
                _windDirection = value;
                OnPropertyChanged(nameof(WindDirection));
            }
        }
    }
}
