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
    public class WeatherConditionModel : NotifyPropertyBase
    {
        private static readonly Random _random = new Random();

        private WeatherConditionCollection _condition;

        private int _sunrise = 0;
        private int _sunset = 0;

       

        public WeatherConditionCollection Condition
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


        public WeatherConditionModel()
        {
        }

        public WeatherConditionModel(WeatherConditionCollection condition)
        {
            Condition = condition;
        }

        public WeatherConditionModel(WeatherConditionCollection condition, int sunrise, int sunset)
        {
            Condition = condition;
            Sunrise = sunrise;
            Sunset = sunset;
        }


        public static WeatherConditionCollection GetRandomWeatherConditionShort()
        {
            return (WeatherConditionCollection)_random.Next(1, 7);
        }


        public static WeatherConditionCollection GetRandomWeatherConditionLong(int currenthour)
        {
            var weatherConditionModel = new WeatherConditionModel();
            weatherConditionModel.Sunrise = 5;
            weatherConditionModel.Sunset = 20;


            if (currenthour == weatherConditionModel.Sunrise)
            {
                return WeatherConditionCollection.sunrise;
            }
            else if (currenthour == weatherConditionModel.Sunset)
            {
                return WeatherConditionCollection.sunset;
            }
            else if (currenthour < weatherConditionModel.Sunrise || currenthour > weatherConditionModel.Sunset)
            {
                return (WeatherConditionCollection)_random.Next(8, 11);
            }
            else
            {
                return (WeatherConditionCollection)_random.Next(1, 7);
            }
        }





    }
}
