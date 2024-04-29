using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WeatherApp.Collections;
using WeatherApp.Models;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WeatherApp.Helpers;

namespace WeatherApp.ViewModels
{
    public class MainViewModel
    {
        // TODO: Provisorisch als Prüfer für die Anzeige im UI, wird gewechselt durch echte Daten
        private Random Random = new Random();


        // Objekt mit den Eigenschaften (Temperatur, Date und enum Condition)
        public HourlyForecast HourlyForecast { get; } = new HourlyForecast();


        // Objekt mit den Eigenschaften (Windspeed und enum Winddirection)
        public WindForecast WindForecast { get; } = new WindForecast();



        public MainViewModel()
        {
            // Zufallszahl für die TagesTemperatur
            // TODO: Methode/Eigenschaft, falls es ein Durchschnittswert ist

            HourlyForecast.Temperatur = Random.Next(-10, 30);


            // Zufallszahl für Windgeschwindigkeit wird gesetzt

            WindForecast.Windspeed = Random.Next(1, 80);


            GenerateImageForWeatherCondition();

            GenerateImageForWinddirection();
        }



        private void GenerateImageForWeatherCondition()
        {
            // Zufallszahl für die Wetterlage (sunny, ...) und das Image

            int randomForWeatherCondition = Random.Next(1, 6);


            // Prüft die Zufallszahl für die Wetterlage und speichert den passenden
            // enum Wert in die Objekt-Variable

            switch (randomForWeatherCondition)
            {
                case 1:
                    HourlyForecast.Condition = WeatherCondition.sunny;
                    break;
                case 2:
                    HourlyForecast.Condition = WeatherCondition.rain;
                    break;
                case 3:
                    HourlyForecast.Condition = WeatherCondition.suncloud;
                    break;
                case 4:
                    HourlyForecast.Condition = WeatherCondition.snow;
                    break;
                case 5:
                    HourlyForecast.Condition = WeatherCondition.cloudy;
                    break;
                default:
                    HourlyForecast.Condition = WeatherCondition.sunny;
                    break;
            }
        }


        private void GenerateImageForWinddirection()
        {
            // Zufallszahl für die Windrichtung (north, ...) und das Image

            int randomForWinddirection = Random.Next(1, 9);


            // Prüft die Zufallszahl für die Windrichtung und speichert den passenden
            // enum Wert in die Objekt-Variable

            switch (randomForWinddirection)
            {
                case 1:
                    WindForecast.WindDirection = Winddirection.east; break;
                case 2:
                    WindForecast.WindDirection = Winddirection.north; break;
                case 3:
                    WindForecast.WindDirection = Winddirection.south; break;
                case 4:
                    WindForecast.WindDirection = Winddirection.west; break;
                case 5:
                    WindForecast.WindDirection = Winddirection.northeast; break;
                case 6:
                    WindForecast.WindDirection = Winddirection.southeast; break;
                case 7:
                    WindForecast.WindDirection = Winddirection.northwest; break;
                case 8:
                    WindForecast.WindDirection = Winddirection.southwest; break;
                default:
                    WindForecast.WindDirection = Winddirection.north; break;
            }
        }





    }
}
