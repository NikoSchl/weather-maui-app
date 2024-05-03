using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Helpers;
using WeatherApp.Models;
using WeatherApp.Collections;

namespace WeatherApp.Models
{
    public class DailyForecastModel : WeatherConditionModel
    {
        private static readonly Random _random = new Random();


        private float _maxTemperatur = 0;
        private float _minTemperatur = 0;


        // enums für die Wochentage (Sunday, Monday, ...)

        private string _weekday = string.Empty;


        public float MaxTemperatur
        {
            get { return _maxTemperatur; }
            set
            {
                // Damit nicht unnötig oft das UI aktuallisiert wird, eine if Abfrage
                // ob eine Veränderung vorliegt, wenn nicht, muss nicht erneuert werden

                if (_maxTemperatur != value)
                {
                    _maxTemperatur = value;
                    OnPropertyChanged(nameof(MaxTemperatur));
                }
            }
        }

        public float MinTemperatur
        {
            get { return _minTemperatur; }
            set
            {
                if (_minTemperatur != value)
                {
                    _minTemperatur = value;
                    OnPropertyChanged(nameof(MinTemperatur));
                }
            }
        }


        public string Weekday
        {
            get { return _weekday; }
            set
            {
                if (_weekday != value)
                {
                    _weekday = value;
                    OnPropertyChanged(nameof(Weekday));
                }
            }
        }




    }
}
