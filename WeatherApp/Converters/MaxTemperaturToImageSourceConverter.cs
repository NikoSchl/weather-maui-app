using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Resources;
using WeatherApp.Models;

namespace WeatherApp.Converters
{
    public class MaxTemperaturToImageSourceConverter : IValueConverter
    {
        private static readonly ImageSource _imageThermoHeiss = ImageSource.FromFile("thermometer_heiss.png");
        private static readonly ImageSource _imageThermoKalt = ImageSource.FromFile("thermometer_kalt.png");

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float Number = (float)value!;

            switch(Number)
            {
                case < 15: return _imageThermoKalt;
                case > 15: return _imageThermoHeiss;
                default: return _imageThermoHeiss;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
