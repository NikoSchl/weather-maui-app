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
        Random Random = new Random();

        public ObservableCollection<DailyForecast> DailyForecasts { get; } = new ObservableCollection<DailyForecast>();

        public SevenDayViewModel()
        {
            GenerateRandomDataForDailyForecast();
        }

        private void GenerateRandomDataForDailyForecast()
        {
            for (int i = 0; i < 7; i++)
            {
                DailyForecast dailyForecast = new DailyForecast();

                int x = Random.Next(1, 6);

                WeatherCondition condition = WeatherCondition.snow;

                int one = Random.Next(-10, 35);
                int two = Random.Next(-10, 35);

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
                dailyForecast.Condition = condition;

                if (one > two)
                {
                    dailyForecast.MaxTemperatur = one;
                    dailyForecast.MinTemperatur = two;
                }
                else
                {
                    dailyForecast.MaxTemperatur = two;
                    dailyForecast.MinTemperatur = one;
                }

                DailyForecasts.Add(dailyForecast);
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
