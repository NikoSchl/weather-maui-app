using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Collections;
using WeatherApp.Helpers;

namespace WeatherApp.Models
{
    public class HourlyForecast : NotifyPropertyHelper
    {
        private float _temperatur = 25;

        // für die Uhrzeit/Stunde und fürs Datum
        private DateTime _date = DateTime.UtcNow;

        private int _intHour = 0;

        private WeatherCondition _condition;


       
        public float Temperatur
        {
            get { return _temperatur; }
            set
            {
                _temperatur = value;
                OnPropertyChanged(nameof(Temperatur));
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

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

        public int IntHour
        {
            get { return _intHour; }
            set
            {
                _intHour = value;
                OnPropertyChanged(nameof(IntHour));
            }
        }
    }
}
