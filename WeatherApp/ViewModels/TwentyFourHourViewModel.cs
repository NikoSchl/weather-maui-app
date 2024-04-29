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
        // Liste in welcher die Objekte für die stündliche Darstellung der 24 Stunden Vorschau
        // im ListView gespeichert/geladen werden
        public ObservableCollection<HourlyForecast> HourlyForecasts { get; } = new ObservableCollection<HourlyForecast>();

        // TODO: Provisorisch als Prüfer für die Anzeige im UI, wird gewechselt durch echte Daten
        private Random Random = new Random();

        // TODO: Notwendigkeit überlegen
        private DateTime date = DateTime.Now;


        WeatherConditionModel weatherConditionModel = new WeatherConditionModel();


        // Variable für das enum wird erstellt

        WeatherCondition condition = WeatherCondition.snow;



        public TwentyFourHourViewModel()
        {
            GenerateRandomWeatherData();
        }


        /// <summary>
        /// Generate the Weather Data for the Time(Hour), the Condition(Image) and the Themperature
        /// </summary>
        private void GenerateRandomWeatherData()
        {
            // TODO: Notwendigkeit und Position überlegen und ob hier oder im class HourlyForecast.cs
            int hour = int.Parse(date.ToString("HH"));
          //  int hour = currentHour;


            // 24 Durchläufe, für 24 Stunden zu befüllen der Liste (ObservableCollection)

            for (int i = 0; i < 24; i++)
            {
                GenerateImageForHourlyWeatherCondition(hour);


                // Objekt wird in die Liste(ObservableCollection) hinzugefügt und 
                // gleichzeitig ein neues Objekt der class HourlyForecast erstellt 

                HourlyForecasts.Add(new HourlyForecast { Condition = condition, Temperatur = Random.Next(-5, 30), IntHour = hour });


                // Prüfung, wenn die Variable für die Sunde 23 beträgt, setze den Wert auf 0
                // ansonsten den Wert um 1 erhöhen

                if (hour == 23)
                { hour = 0; }
                else
                { hour = hour + 1; }
            }
        }


        private void GenerateImageForHourlyWeatherCondition(int hour)
        {
            // Zufallszahl zwischen 1 und 5 da das enum WeatherCondition aus 5 Werten besteht

            int randomForWeatherCondition = Random.Next(1, 7);
            int randomForNightWeatherCondition = Random.Next(1, 4);


            weatherConditionModel.Sunrise = 5;
            weatherConditionModel.Sunset = 20;


            if (hour == weatherConditionModel.Sunrise)
            {
                condition = WeatherCondition.sunrise;
            }
            else if (hour == weatherConditionModel.Sunset)
            {
                condition = WeatherCondition.sunset;
            }
            else if (hour < weatherConditionModel.Sunrise || hour > weatherConditionModel.Sunset)
            {
                switch (randomForNightWeatherCondition)
                {
                    case 1:
                        condition = WeatherCondition.moon;
                        break;
                    case 2:
                        condition = WeatherCondition.nightcloud;
                        break;
                    case 3:
                        condition = WeatherCondition.nightrain;
                        break;
                    default:
                        condition = WeatherCondition.moon;
                        break;
                }
            }
            else
            {
                // im switch wird die Zufallszahl (Variable randomForWeatherCondition) geprüft/ 
                // verglichen und der definierte enum-Wert in die Variable condition gespeichert

                switch (randomForWeatherCondition)
                {
                    // erster Fall(case) ist identisch mit:
                    // if(randomForWeatherCondition == 1)
                    // { condition = WeatherCondition.sunny; }

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
                    case 6:
                        condition = WeatherCondition.thunder;
                        break;
                    default:
                        condition = WeatherCondition.sunny;
                        break;
                }
            }
        }



    }
}
