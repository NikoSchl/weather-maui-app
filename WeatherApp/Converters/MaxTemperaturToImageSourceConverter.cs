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
        private static readonly ImageSource _imageThermoMittel = ImageSource.FromFile("thermometer_mittel.png");


        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
            { return _imageThermoMittel; }


            float Number = (float)value;


            switch (Number)
            {
                case <= 10:
                    return _imageThermoKalt;
                case >= 20:
                    return _imageThermoHeiss;
                case > 10 and < 20:
                    return _imageThermoMittel;
                default:
                    return _imageThermoHeiss;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
