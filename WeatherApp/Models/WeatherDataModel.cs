using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Helpers;
using WeatherApp.Models;
using WeatherApp.Collections;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WeatherApp.Attribut;

namespace WeatherApp.Models
{
    [ForecastTable(Name = "wetterdaten")]
    public class WeatherDataModel : NotifyPropertyBase
    {
        private static readonly Random _random = new Random();


        //   ------------------ Eigenschaften ------------------ //

        private DateTime _date;
        private Timer _timer;

        private int _temperatureCelsius = 0;

        private WindForecastModel _windForecastModel;

        private RiskOfRainModel _riskOfRainModel;

        // enum
        private WeatherConditionCollection _weatherConditionCollection;

        private DayTimeCollection _dayTimeCollection;

        // für die Stunde (Hour) in der 24-Stunden-View-Ansicht
        private int _intHour = 0;
        private DateTime _tomorrow = DateTime.Today.AddDays(1);

        public DateTime Tomorrow
        {
            get { return _tomorrow; }
            set
            {
                if (_tomorrow != value)
                {
                    _tomorrow = value;
                    OnPropertyChanged(nameof(Tomorrow));
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

        [ForecastColumn(Name = "Datum", DbTyp = ("DATETIME"))]
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

      
        public WindForecastModel WindForecastModel
        {
            get { return _windForecastModel; }
            set
            {
                if (_windForecastModel != value)
                {
                    _windForecastModel = value;
                    OnPropertyChanged(nameof(WindForecastModel));
                }
            }
        }

        public RiskOfRainModel RiskOfRainModel
        {
            get { return _riskOfRainModel; }
            set
            {
                if (_riskOfRainModel != value)
                {
                    _riskOfRainModel = value;
                    OnPropertyChanged(nameof(RiskOfRainModel));
                }
            }
        }

        public WeatherConditionCollection WeatherConditionCollection
        {
            get { return _weatherConditionCollection; }
            set
            {
                if (_weatherConditionCollection != value)
                {
                    _weatherConditionCollection = value;
                    OnPropertyChanged(nameof(WeatherConditionCollection));
                }
            }
        }

        public DayTimeCollection DayTimeCollection
        {
            get { return _dayTimeCollection; }
            set
            {
                if (_dayTimeCollection != value)
                {
                    _dayTimeCollection = value;
                    OnPropertyChanged(nameof(DayTimeCollection));
                }
            }
        }


        //   ------------------ Konstruktoren ------------------ //

        public WeatherDataModel()
        {
        }

        // Mainpage
        public WeatherDataModel(int temperature, WindForecastModel windForecastModel, WeatherConditionCollection weatherConditionCollection)
        {
            Date = DateTime.Now;
            _timer = new Timer(new TimerCallback((s) => Date = DateTime.Now), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

            TemperatureCelsius = temperature;
            WindForecastModel = windForecastModel;
            WeatherConditionCollection = weatherConditionCollection;
        }

        // TomorrowPage
        public WeatherDataModel(int temperature, WindForecastModel windForecastModel, RiskOfRainModel riskOfRainModel,WeatherConditionCollection weatherConditionCollection)
        {
            TemperatureCelsius = temperature;
            WindForecastModel = windForecastModel;
            RiskOfRainModel = riskOfRainModel;
            WeatherConditionCollection = weatherConditionCollection;
        }

        // HourlyPage
        public WeatherDataModel(int temperature, WeatherConditionCollection weatherConditionCollection)
        {
            TemperatureCelsius = temperature;
            WeatherConditionCollection = weatherConditionCollection;
        }


        //   ------------------ Methoden zum generieren von Mockup Daten ------------------ //

        public static WeatherDataModel GenerateDataForMainPage()
        {
            int temperature = _random.Next(-10,35);
            WindForecastModel windForecastModel = WindForecastModel.GenerateWindForecast();
            WeatherConditionCollection weatherConditionCollection = WeatherConditionModel.GetRandomWeatherConditionShort();
            return new WeatherDataModel(temperature, windForecastModel, weatherConditionCollection);
        }


        public static WeatherDataModel GenerateDataForTomorrowPage()
        {
            int temperature = _random.Next(-10, 35);
            WindForecastModel windForecastModel = WindForecastModel.GenerateWindForecast();
            RiskOfRainModel riskOfRainModel = RiskOfRainModel.GenerateRiskOfRain();
            WeatherConditionCollection weatherConditionCollection = WeatherConditionModel.GetRandomWeatherConditionShort();
            return new WeatherDataModel(temperature, windForecastModel, riskOfRainModel, weatherConditionCollection);
        }

        public static WeatherDataModel GenerateDataForHourlyPage()
        {
            int temperature = _random.Next(-10, 35);
            WeatherConditionCollection weatherConditionCollection = WeatherConditionModel.GetRandomWeatherConditionShort();
            return new WeatherDataModel(temperature, weatherConditionCollection);
        }

    }
}
