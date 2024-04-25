using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Collections;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class SevenDayViewModel
    {
        public ObservableCollection<DailyForecast> DailyForecasts { get; } = new ObservableCollection<DailyForecast>();

        public SevenDayViewModel()
        {
            for (int i = 0; i < 7; i++)
            {
                DailyForecasts.Add(new DailyForecast());
            }
        }

        /// <summary>
        /// Function load the Data for the App in the ObservableCollection List
        /// </summary>
        public void LoadDailyForecastRepresentation()
        {
            //Provisorisch
            //string[] data = new string[7];

            //for (int i = 0; i < data.Length; i++)
            //{
            //    string[] value = data[i];
            //    DailyForecast forecast = new DailyForecast();

            //    forecast.Day = Enum.Parse<Weekday>(value[0]);
            //    forecast.MaxTemperatur = value[1];
            //    forecast.MinTemperatur = value[2];

            //    DailyForecasts.Add(forecast);
            //}
        }
    }
}
