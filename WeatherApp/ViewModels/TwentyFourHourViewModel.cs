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

        private Random Random = new Random();
        private DateTime date = DateTime.Now;


        public TwentyFourHourViewModel()
        {
            GenerateRandomData();
        }



        private void GenerateRandomData()
        {
            int currentHour = int.Parse(date.ToString("HH"));
            int hour = currentHour;

            for (int i = 0; i < 24; i++)
            {
                int x = Random.Next(1, 6);

                WeatherCondition condition = WeatherCondition.snow;

                switch (x)
                {
                    case 1:
                        condition = WeatherCondition.sunny;
                        break;
                    case 2:
                        condition = WeatherCondition.rain;
                        break;
                    case 3:
                        condition = WeatherCondition.suncloud;
                        break;
                    case 4:
                        condition = WeatherCondition.snow;
                        break;
                    case 5:
                        condition = WeatherCondition.cloudy;
                        break;
                    default:
                        condition = WeatherCondition.sunny;
                        break;
                }

                HourlyForecasts.Add(new HourlyForecast { Condition = condition, Temperatur = Random.Next(-5, 30), IntHour = hour });

                if (hour == 23)
                {
                    hour = 0;
                }
                else
                {
                    hour = hour + 1;
                }
            }
        }
    }
}
