using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Collections;

namespace WeatherApp.Converters
{
    internal class WeatherConditionToImageSourceConvert : IValueConverter
    {
        private static readonly ImageSource _imageSunny = ImageSource.FromFile("son_wol.png");
        private static readonly ImageSource _imageRain = ImageSource.FromFile("sun_two.png");
        private static readonly ImageSource _imageCloudy = ImageSource.FromFile("son_wol.png");
        private static readonly ImageSource _imageStorm = ImageSource.FromFile("son_wol.png");
        private static readonly ImageSource _imageSnow = ImageSource.FromFile("son_wol.png");

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            WeatherCondition condition = (WeatherCondition)value!;

            switch(condition)
            {
                case WeatherCondition.sunny:
                    return _imageSunny;
                case WeatherCondition.rain:
                    return _imageRain;
                case WeatherCondition.cloudy:
                    return _imageCloudy;
                case WeatherCondition.storm:
                    return _imageStorm;
                case WeatherCondition.snow:
                    return _imageSnow;
                default: 
                    return _imageSunny;

            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
