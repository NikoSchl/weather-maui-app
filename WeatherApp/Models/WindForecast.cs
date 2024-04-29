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
        private static readonly Random _random = new Random();
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



        public static WindForecast GenerateWindForecast()
        {
            var windForecast = new WindForecast();
            windForecast.Windspeed = _random.Next(1, 80);
            windForecast.WindDirection = GetRandomWindDirection();
            return windForecast;
        }

        private static Winddirection GetRandomWindDirection()
        {
            switch (_random.Next(1, 9))
            {
                case 1:
                    return Winddirection.east;
                case 2:
                    return Winddirection.north; 
                case 3:
                    return Winddirection.south; 
                case 4:
                    return Winddirection.west; 
                case 5:
                    return Winddirection.northeast; 
                case 6:
                    return Winddirection.southeast; 
                case 7:
                    return Winddirection.northwest; 
                case 8:
                    return Winddirection.southwest; 
                default:
                    return Winddirection.north; 
            }  
        }
    }
}
