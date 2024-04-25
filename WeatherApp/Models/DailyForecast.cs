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
    public class DailyForecast : NotifyProperty
    {
        private string _maxTemperatur = string.Empty;
        private string _minTemperatur = string.Empty;

        private Weekday _day;
        private string _dayForecast = string.Empty;


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

        public string DayForecast
        {
            get
            {
                return _dayForecast;
            }
            set
            {
                _dayForecast = value;
                OnPropertyChanged(nameof(DayForecast));
            }
        }
    }
}
