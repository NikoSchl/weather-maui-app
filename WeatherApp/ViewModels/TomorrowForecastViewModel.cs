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
        public ObservableCollection<WeatherDataMainModel> TomorrowList { get; } = new ObservableCollection<WeatherDataMainModel>();

     

        public void InitializeData()
        {
            for (int i = 0; i < 4; i++)
            {
                WeatherDataMainModel WeatherDataModel = WeatherDataMainModel.GenerateDataForMainPage();
                WeatherDataModel.DayTimeCollection = (DayTimeCollection)i;
                TomorrowList.Add(WeatherDataModel);
            }
        }

    }
}
