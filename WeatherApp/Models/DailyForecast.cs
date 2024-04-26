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
        private float _maxTemperatur = 0;
        private float _minTemperatur = 0;

        private Weekday _day;
        private string _weekday = string.Empty;
        private WeatherCondition _condition;

        public float MaxTemperatur 
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

        public float MinTemperatur
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

        public WeatherCondition Condition
        {
            get { return _condition; }
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }

        public string Weekday
        {
            get
            {
                return _weekday;
            }
            set
            {
                _weekday = value;
                OnPropertyChanged(nameof(Weekday));

            }
        }
    }
}
