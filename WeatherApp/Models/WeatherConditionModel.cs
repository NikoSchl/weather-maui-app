using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

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


        private static WeatherCondition GetRandomWeatherConditionShort()
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


        private static WeatherCondition GetRandomWeatherConditionLong(int currenthour)
        {
            var weatherConditionModel = new WeatherConditionModel();
            weatherConditionModel.Sunrise = 5;
            weatherConditionModel.Sunset = 20;


            if (currenthour == weatherConditionModel.Sunrise)
            {
                return WeatherCondition.sunrise;
            }
            else if (currenthour == weatherConditionModel.Sunset)
            {
                return WeatherCondition.sunset;
            }
            else if (currenthour < weatherConditionModel.Sunrise || currenthour > weatherConditionModel.Sunset)
            {
                switch (_random.Next(1, 4))
                {
                    case 1:
                        return WeatherCondition.moon;
                    case 2:
                        return WeatherCondition.nightcloud;
                    case 3:
                        return WeatherCondition.nightrain;
                    default:
                        return WeatherCondition.moon;
                }
            }
            else
            {
                // im switch wird die Zufallszahl (Variable randomForWeatherCondition) geprüft/ 
                // verglichen und der definierte enum-Wert in die Variable condition gespeichert

                switch (_random.Next(1, 7))
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
                    case 6:
                        return WeatherCondition.thunder;
                    default:
                        return WeatherCondition.sunny;
                }
            }
        }





    }
}
