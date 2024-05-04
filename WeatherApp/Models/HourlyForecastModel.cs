using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Collections;
using WeatherApp.Helpers;

namespace WeatherApp.Models
{
    [Obsolete("This class is obsolet. Use WeatherDataMainModel")]
    public class HourlyForecastModel : WeatherConditionModel
    {
        private float _temperatur = 25;

        // für die Uhrzeit/Stunde und fürs Datum
        private DateTime _date;


        // für die Stunde (Hour) in der 24-Stunden-View-Ansicht
        private int _intHour = 0;



        [Obsolete("This Property is obsolet. Use the Temperature from TemperatureCelsiusModel")]
        public float Temperatur
        {
            get { return _temperatur; }
            set
            {
                if (_temperatur != value)
                {
                    _temperatur = value;
                    OnPropertyChanged(nameof(Temperatur));
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged(nameof(Date));
                }
            }
        }

        public int IntHour
        {
            get { return _intHour; }
            set
            {
                if (_intHour != value)
                {
                    _intHour = value;
                    OnPropertyChanged(nameof(IntHour));
                }
            }
        }


    }
}
