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

        // TODO: Provisorisch als Prüfer für die Anzeige im UI, wird gewechselt durch echte Daten
        private Random Random = new Random();

        // TODO: Notwendigkeit überlegen
        private DateTime date = DateTime.Now;


        WeatherConditionModel weatherConditionModel = new WeatherConditionModel();


        // Variable für das enum wird erstellt

        WeatherCondition condition = WeatherCondition.snow;


        public TwentyFourHourViewModel()
        {
        }


        public void InitializeData()
        {
            if (HourlyForecasts.Count == 0)
            {
                GenerateRandomWeatherData();
            }
        }

        //public void CleanUpData()
        //{
        //    HourlyForecasts.Clear();
        //}


        /// <summary>
        /// Generate the Weather Data for the Time(Hour), the Condition(Image) and the Themperature
        /// </summary>
        private void GenerateRandomWeatherData()
        {
            // TODO: Notwendigkeit und Position überlegen und ob hier oder im class HourlyForecast.cs
            int hour = int.Parse(date.ToString("HH"));


            // 24 Durchläufe, für 24 Stunden zu befüllen der Liste (ObservableCollection)

            for (int i = 0; i < 24; i++)
            {
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
                    condition = (WeatherCondition)Random.Next(8, 11);
                }
                else
                {
                    condition = (WeatherCondition)Random.Next(1, 6);
                }


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



    }
}
