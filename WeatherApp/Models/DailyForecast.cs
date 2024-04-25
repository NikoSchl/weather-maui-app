using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Helpers;
using WeatherApp.Collections;

namespace WeatherApp.Models
{
    public class DailyForecast : NotifyPropertyHelper
    {
        private string _maxTemperatur = "12";
        private string _minTemperatur = "6";

        private Weekday _day;

        public string MaxTemperatur 
        { 
            get
            {
                return _maxTemperatur;
            } 
            set
            {
                _maxTemperatur = value;
                OnPropertyChanged(nameof(MaxTemperatur));
            }
        }

        public string MinTemperatur
        {
            get
            {
                return _minTemperatur;
            }
            set
            {
                _minTemperatur = value;
                OnPropertyChanged(nameof(MinTemperatur));
            }
        }

        public Weekday Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
                OnPropertyChanged(nameof(Day));
            }
        }

    }
}
