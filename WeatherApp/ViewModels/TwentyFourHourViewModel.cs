using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WeatherApp.Collections;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModels
{
    public class TwentyFourHourViewModel
    {
        public HourlyForecast HourlyForecast { get; } = new HourlyForecast();
        public ObservableCollection<HourlyForecast> HourlyForecasts { get; } = new ObservableCollection<HourlyForecast>();

        public TwentyFourHourViewModel()
        {
            for (int i = 0; i < 7; i++)
            {
                HourlyForecasts.Add(HourlyForecast);
            }
        }

        /// <summary>
        /// Function load the Data for the App in the ObservableCollection List
        /// </summary>
        public void LoadHourlyForecastRepresentation()
        {
            //Provisorisch
          
        }
    }
}
