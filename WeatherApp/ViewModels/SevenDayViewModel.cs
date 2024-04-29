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
        // List in which the objects for the daily Forecast are saved/loaded in the CollectionView
        public ObservableCollection<DailyForecast> DailyForecasts { get; } = new ObservableCollection<DailyForecast>();


        // TODO: Provisionally as a checker for the display in the UI, it is replaced by real data
        Random Random = new Random();



        public SevenDayViewModel()
        {
            GenerateRandomDataForDailyForecast();
        }


        private void GenerateRandomDataForDailyForecast()
        {
            // TODO: Notwendigkeit im ViewModel überlegen

            DateTime dateValue = DateTime.Now;
            int dayOfWeekNumber = (int)dateValue.DayOfWeek;


            // sieben Durchläufe für sieben Tage der Woche

            for (int i = 0; i < 7; i++)
            {
                // neues Objekt erstellt, mit vier werten
                // (MaxTemperatur, MinTemperatur, Weekday, Condition)

                DailyForecast dailyForecast = new DailyForecast();


                GenerateWeatherCondition(dailyForecast);


                GenerateMinMaxTemperatur(dailyForecast);


                // Die Variable muss um eins erhöht werden damit der erste Tag der morgige ist
                // und bei 6 auf 0 zurücksetzen

                if (dayOfWeekNumber == 6)
                { dayOfWeekNumber = 0; }
                else
                { dayOfWeekNumber = dayOfWeekNumber + 1; }


                // TODO: Converter (WeekdayToStringConverter) um die string (Sun, Mon,...) durch
                // das enum zu ersetzen

                // Die Zahl des heutigen Wochentages wird geprüft und der entsprechende string in
                // die Objekt-Variable Weekday gespeichert

                switch (dayOfWeekNumber)
                {
                    case 0:
                        dailyForecast.Weekday = "Sun"; break;
                    case 1:
                        dailyForecast.Weekday = "Mon"; break;
                    case 2:
                        dailyForecast.Weekday = "Tue"; break;
                    case 3:
                        dailyForecast.Weekday = "Wed"; break;
                    case 4:
                        dailyForecast.Weekday = "Thu"; break;
                    case 5:
                        dailyForecast.Weekday = "Fri"; break;
                    case 6:
                        dailyForecast.Weekday = "Sat"; break;
                    default:
                        dailyForecast.Weekday = "Sun"; break;
                }


                // Objekt mit allen gefüllten Daten wird in die ObservableCollection hinzugefügt

                DailyForecasts.Add(dailyForecast);
            }
        }



        private void GenerateMinMaxTemperatur(DailyForecast dailyForecast)
        {
            // zwei Zwischenvariablen für die Min Max Werte

            int temperatureOne = Random.Next(-10, 35);
            int temperatureTwo = Random.Next(-10, 35);


            // Prüfung welche der beiden Zufallszahlen die größere ist
            // um dann in die Objekt-Variable MaxTemperatur zu speichern

            if (temperatureOne >= temperatureTwo)
            {
                dailyForecast.MaxTemperatur = temperatureOne;
                dailyForecast.MinTemperatur = temperatureTwo;
            }
            else
            {
                dailyForecast.MaxTemperatur = temperatureTwo;
                dailyForecast.MinTemperatur = temperatureOne;
            }
        }


        private void GenerateWeatherCondition(DailyForecast dailyForecast)
        {
            // Zufallszahl für den switch

            int randomForWeatherCondition = Random.Next(1, 6);


            // im switch wird die Variable randomForWeatherCondition geprüft/ verglichen
            // und der dahinterliegende enum-Wert in die Objekt-Variable Condition gespeichert

            switch (randomForWeatherCondition)
            {
                case 1:
                    dailyForecast.Condition = WeatherCondition.sunny;
                    break;
                case 2:
                    dailyForecast.Condition = WeatherCondition.rain;
                    break;
                case 3:
                    dailyForecast.Condition = WeatherCondition.suncloud;
                    break;
                case 4:
                    dailyForecast.Condition = WeatherCondition.snow;
                    break;
                case 5:
                    dailyForecast.Condition = WeatherCondition.cloudy;
                    break;
                default:
                    dailyForecast.Condition = WeatherCondition.sunny;
                    break;
            }
        }






    }
}
