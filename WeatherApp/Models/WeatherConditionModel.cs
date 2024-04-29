using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherConditionModel : NotifyPropertyHelper
    {
        private static readonly Random _random = new Random();

        private WeatherCondition _condition;

        private int _sunrise = 0;
        private int _sunset = 0;


        public WeatherCondition Condition
        {
            get { return _condition; }
            set
            {
                if (_condition != value)
                {
                    _condition = value;
                    OnPropertyChanged(nameof(Condition));
                }
            }
        }


        public int Sunrise
        {
            get { return _sunrise; }
            set
            {
                if (_sunrise != value)
                {
                    _sunrise = value;
                    OnPropertyChanged(nameof(Sunrise));
                }
            }
        }


        public int Sunset
        {
            get { return _sunset; }
            set
            {
                if (_sunset != value)
                {
                    _sunset = value;
                    OnPropertyChanged(nameof(Sunset));
                }
            }
        }


        private static WeatherCondition GetRandomWeatherCondition()
        {
            switch (_random.Next(1, 6))
            {
                case 1:
                    return WeatherCondition.sunny;
                case 2:
                    return WeatherCondition.rain;
                case 3:
                    return WeatherCondition.suncloud;
                case 4:
                    return WeatherCondition.snow;
                case 5:
                    return WeatherCondition.cloudy;
                default:
                    return WeatherCondition.sunny;
            }
        }


    }
}
