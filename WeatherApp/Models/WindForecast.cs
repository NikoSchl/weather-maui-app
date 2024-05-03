using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WindForecast : NotifyPropertyBase
    {
        private static readonly Random _random = new Random();
        private float _windSpeed = 0;

        // enum für die acht möglichen Windrichtungen
        private WindDirectionCollection _windDirection;


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

        public WindDirectionCollection WindDirection
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



        public static WindForecast GenerateWindForecast()
        {
            var windForecast = new WindForecast();
            windForecast.Windspeed = _random.Next(1, 80);
            // konvertiert eine Zufallszahl zwischen 1 und 8 in den enum Wert und gibt diesen aus
            windForecast.WindDirection = (WindDirectionCollection)_random.Next(1, 9);
            return windForecast;
        }






    }
}
