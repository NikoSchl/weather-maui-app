using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WeatherApp.Collections;
using WeatherApp.Models;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModels
{
    public class MainViewModel
    {
        private Random Random = new Random();

        public WindForecast windForecast { get; } = new WindForecast();

        public HourlyForecast HourlyForecast { get; } = new HourlyForecast();

        public MainViewModel()
        {
            
            GenerateRandomDataForWindDirection();
        }

        private void GenerateRandomDataForWindDirection()
        {  
            int x = Random.Next(1,9);

            HourlyForecast.Temperatur = Random.Next(-10, 30);

            Winddirection winddirection = Winddirection.east;

            switch(x)
            {
                case 1:
                    winddirection = Winddirection.east; break;
                case 2:
                    winddirection = Winddirection.north; break;
                case 3:
                    winddirection = Winddirection.south; break;
                case 4:
                    winddirection = Winddirection.west; break;
                case 5:
                    winddirection = Winddirection.northeast; break;
                case 6:
                    winddirection = Winddirection.southeast; break;
                case 7:
                    winddirection = Winddirection.northwest; break;
                case 8:
                    winddirection = Winddirection.southwest; break;
                default:
                    winddirection = Winddirection.north; break;
            }

            windForecast.WindDirection = winddirection;
            windForecast.Windspeed = Random.Next(1, 80);



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

            HourlyForecast.Condition = condition;
        }
    }
}
