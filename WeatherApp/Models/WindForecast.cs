using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WindForecast : NotifyPropertyHelper
    {
        private float _windSpeed = 0;

        // enum für die acht möglichen Windrichtungen
        private Winddirection _windDirection;


        public float Windspeed
        {
            get { return _windSpeed; }
            set
            {
                if (_windSpeed != value)
                {
                    _windSpeed = value;
                    OnPropertyChanged(nameof(Windspeed));
                }
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
                if (_windDirection != value)
                {
                    _windDirection = value;
                    OnPropertyChanged(nameof(WindDirection));
                }
            }
        }
    }
}
