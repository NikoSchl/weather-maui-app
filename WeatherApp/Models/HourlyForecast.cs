using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Collections;
using WeatherApp.Helpers;

namespace WeatherApp.Models
{
    public class HourlyForecast : WeatherConditionModel
    {
        private static readonly Random _random = new Random();

        private float _temperatur = 25;

        // für die Uhrzeit/Stunde und fürs Datum
        private DateTime _date;
        private Timer _timer;


        // für die Stunde (Hour) in der 24-Stunden-View-Ansicht
        private int _intHour = 0;



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

        public Timer Timer
        {
            get { return _timer; }
            set
            {
                if (_timer != value)
                {
                    _timer = value;
                    OnPropertyChanged(nameof(Timer));
                }
            }
        }


        public HourlyForecast()
        {
            Date = DateTime.Now;

            _timer = new Timer(new TimerCallback((s) => Date = DateTime.Now), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }


        // Generiert eine Instanz für die MainPage mit den Eigenschaften Temperatur und WeatherCondition
        // <returns>gefüllte Instanz
        public static HourlyForecast GenerateHourlyForecastForMainPage()
        {
            // Instanz wird erstellt
            var hourlyForecast = new HourlyForecast();
            // Temperatur wird mit einem Zufallswert erstellt
            hourlyForecast.Temperatur = _random.Next(-10, 30);
            // für die Condition wird die Methode aufgerufen, welche aus dem enum ein Zufallswert generiert
            hourlyForecast.Condition = (WeatherCondition)_random.Next(1, 7);
            // gibt die gefüllte Instanz zurück
            return hourlyForecast;
        }






    }
}
