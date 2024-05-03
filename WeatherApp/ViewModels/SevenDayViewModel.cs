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

        public Command NavigateToDetailPageCommand { get; }


        // TODO: Provisionally as a checker for the display in the UI, it is replaced by real data
        Random Random = new Random();



        public SevenDayViewModel()
        {
            NavigateToDetailPageCommand = new Command(NavigateToDetailPage);
        }


        public void InitializeData()
        {
            GenerateRandomDataForDailyForecast();

            //for(int i = 0; i < 7; i++)
            //{
            //    DailyForecasts.Add(DailyForecast.GenerateDailyForecast());
            //}
        
        }

        public void CleanUpData()
        {
            DailyForecasts.Clear();
        }


        private async void NavigateToDetailPage()
        {
            await AppShell.Current.GoToAsync(AppShell.CreateDetailPageRoute);
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

                dailyForecast.Condition = (WeatherConditionCollection) Random.Next(1, 6);

                dailyForecast.MaxTemperatur = Random.Next(10, 35);
                dailyForecast.MinTemperatur = Random.Next(-10, 10);


                // Die Variable muss um eins erhöht werden damit der erste Tag der morgige ist
                // und bei 6 auf 0 zurücksetzen

                if (dayOfWeekNumber == 6)
                { dayOfWeekNumber = 0; }
                else
                { dayOfWeekNumber = dayOfWeekNumber + 1; }


                // TODO: rüber ins Model DailyForecast
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





    }
}
