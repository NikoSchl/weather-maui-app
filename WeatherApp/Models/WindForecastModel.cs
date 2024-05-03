using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WindForecastModel : NotifyPropertyBase
    {
        private static readonly Random _random = new Random();

        //   ------------------ Eigenschaften ------------------ //

        private float _windSpeedKmh = 0;

        // enum
        private WindDirectionCollection _windDirection;


        public float WindSpeedKmh
        {
            get { return _windSpeedKmh; }
            set
            {
                if (_windSpeedKmh != value)
                {
                    _windSpeedKmh = value;
                    OnPropertyChanged(nameof(WindSpeedKmh));
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


        //   ------------------ Konstruktoren ------------------ //

        public WindForecastModel()
        {
        }

        public WindForecastModel(float windSpeedKmh, WindDirectionCollection windDirection)
        {
            WindSpeedKmh = windSpeedKmh;
            WindDirection = windDirection;
        }


        //   ------------------ Methoden zum generieren von Mockup Daten ------------------ //

        public static WindForecastModel GenerateWindForecast()
        {
            var windForecast = new WindForecastModel();
            windForecast.WindSpeedKmh = _random.Next(1, 80);
            // konvertiert eine Zufallszahl zwischen 1 und 8 in den enum Wert und gibt diesen aus
            windForecast.WindDirection = (WindDirectionCollection)_random.Next(1, 9);
            return windForecast;
        }






    }
}
