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
using WeatherApp.Views;

namespace WeatherApp.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        private WeatherDataMainModel? _weatherDataModel;
        public WeatherDataMainModel? WeatherDataModel
        {
            get { return _weatherDataModel; }
            private set
            {
                if(value != _weatherDataModel)
                {
                    _weatherDataModel = value;
                    OnPropertyChanged(nameof(WeatherDataModel));
                }
            }
        }



        public void InitializeData()
        {
            WeatherDataModel = WeatherDataMainModel.GenerateDataForMainPage();
        }
    }
}
