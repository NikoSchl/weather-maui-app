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
        public ObservableCollection<HourlyForecast> HourlyForecasts { get; } = new ObservableCollection<HourlyForecast>();

        public TwentyFourHourViewModel()
        {
            for (int i = 0; i < 7; i++)
            {
                WeatherCondition condition = WeatherCondition.snow;

                if (i == 1)
                    condition = WeatherCondition.sunny;
                else if(i == 2)
                    condition = WeatherCondition.rain;

                HourlyForecasts.Add(new HourlyForecast {  Condition = condition});
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
