using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Helpers;
using WeatherApp.Collections;
using WeatherApp.Attribut;

namespace WeatherApp.Models
{
    [ForecastTable(Name = "temperatur")]
    public class TemperatureCelsiusModel : NotifyPropertyBase
    {
        private static readonly Random _random = new Random();


        //   ------------------ Eigenschaften ------------------ //

        private int _temperatureCelsius = 0;

        private int _maxTemperaturCelsius = 0;
        private int _minTemperaturCelsius = 0;
      

        [ForecastColumn(Name = "max_Temperatur",DbTyp = "NVARCHAR (3)")]
        public int MaxTemperaturCelsius
        {
            get { return _maxTemperaturCelsius; }
            set
            {
                // Damit nicht unnötig oft das UI aktuallisiert wird, eine if Abfrage
                // ob eine Veränderung vorliegt, wenn nicht, muss nicht erneuert werden

                if (_maxTemperaturCelsius != value)
                {
                    _maxTemperaturCelsius = value;
                    OnPropertyChanged(nameof(MaxTemperaturCelsius));
                }
            }
        }

        [ForecastColumn(Name = "min_Temperatur", DbTyp = "NVARCHAR (3)")]
        public int MinTemperaturCelsius
        {
            get { return _minTemperaturCelsius; }
            set
            {
                if (_minTemperaturCelsius != value)
                {
                    _minTemperaturCelsius = value;
                    OnPropertyChanged(nameof(MinTemperaturCelsius));
                }
            }
        }

        [ForecastColumn(Name = "Temperatur", DbTyp = "NVARCHAR (3)")]
        public int TemperatureCelsius
        {
            get { return _temperatureCelsius; }
            set
            {
                if (_temperatureCelsius != value)
                {
                    _temperatureCelsius = value;
                    OnPropertyChanged(nameof(TemperatureCelsius));
                }
            }
        }


        //   ------------------ Konstruktoren ------------------ //

        public TemperatureCelsiusModel() 
        { }

        public TemperatureCelsiusModel(int temperatureCelsius)
        {
            TemperatureCelsius = temperatureCelsius;
        }

        public TemperatureCelsiusModel(int maxTemperaturCelsius, int minTemperaturCelsius)
        {
            MaxTemperaturCelsius = maxTemperaturCelsius;
            MinTemperaturCelsius = minTemperaturCelsius;
        }

        public TemperatureCelsiusModel(int temperatureCelsius, int maxTemperaturCelsius, int minTemperaturCelsius)
        {
            TemperatureCelsius = temperatureCelsius;
            MaxTemperaturCelsius = maxTemperaturCelsius;
            MinTemperaturCelsius = minTemperaturCelsius;
        }


        //   ------------------ Methoden zum generieren von Mockup Daten ------------------ //

        public static TemperatureCelsiusModel GenerateTemperature()
        {
            return new TemperatureCelsiusModel(_random.Next(-10, 35), _random.Next(10, 35), _random.Next(-10, 10));
        }
    }
}
