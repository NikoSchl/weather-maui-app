using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WeatherApp.Resources;
using WeatherApp.Collections;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using System.Collections.ObjectModel;

namespace WeatherApp.ViewModels
{
    public class SettingsViewModel
    {
        private string WeatherFile = @"C:\Users\Nicole\Repositories\weather-maui-app\WeatherApp\Resources\Files\WeatherData.csv";

        WeatherDataModel weatherDataModel = new WeatherDataModel();
        public ObservableCollection<WeatherDataModel> WeatherDatas { get; } = new ObservableCollection<WeatherDataModel>();

        public Command SaveWeatherDataCommand { get; }
        public Command LoadWeatherDataCommand { get; }
        

        public SettingsViewModel() 
        {
            weatherDataModel = WeatherDataModel.GenerateDataForMainPage();

            SaveWeatherDataCommand = new Command(() =>
            {
                SaveWeatherDataInCsvFile();
            });

            LoadWeatherDataCommand = new Command(() =>
            {
                WeatherDatas.Clear();
                LoadWeatherDataFromCsvFile();
            });
        }

        public void SaveWeatherDataInCsvFile()
        {
            if (!File.Exists(WeatherFile))
            {
                File.WriteAllText(WeatherFile, "Datum/Uhrzeit,Grad Celsius,Wetterlage" + Environment.NewLine);
            }
            File.AppendAllTextAsync(WeatherFile, weatherDataModel.GetCsvStringRepresentation());
            WeatherDatas.Add(weatherDataModel);

            Debug.WriteLine("Daten wurden gespeichert");
        }

        public void LoadWeatherDataFromCsvFile()
        {
            string[] lines = File.ReadAllLines(WeatherFile);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] value = lines[i].Split(',');

                WeatherDataModel weatherData = new WeatherDataModel();
                weatherData.Date = DateTime.Parse(value[0]);
                weatherData.TemperatureCelsius = int.Parse(value[1]);
                weatherData.WeatherConditionCollection = (WeatherConditionCollection)int.Parse(value[2]);

                WeatherDatas.Add(weatherData);
            }
        }
    }
}
