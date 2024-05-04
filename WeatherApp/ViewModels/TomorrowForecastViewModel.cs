using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WeatherApp.Helpers;
using WeatherApp.Models;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WeatherApp.Collections;

namespace WeatherApp.ViewModels
{
    public class TomorrowForecastViewModel : NotifyPropertyBase
    {
        public ObservableCollection<WeatherDataModel> TomorrowList { get; } = new ObservableCollection<WeatherDataModel>();

     

        public void InitializeData()
        {
            Random _random = new Random();
            for (int i = 0; i < 4; i++)
            {
                WeatherDataModel WeatherDataModel = WeatherDataModel.GenerateDataForTomorrowPage();
                WeatherDataModel.DayTimeCollection = (DayTimeCollection)i;
                TomorrowList.Add(WeatherDataModel);
            }
        }

    }
}
