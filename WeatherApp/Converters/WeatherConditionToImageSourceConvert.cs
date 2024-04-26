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
        private static readonly ImageSource _imageSunny = ImageSource.FromFile("sunny_sun.png");
        private static readonly ImageSource _imageRain = ImageSource.FromFile("rain_cloud.png");
        private static readonly ImageSource _imageCloudy = ImageSource.FromFile("cloudy.png");
        private static readonly ImageSource _imageSunCloud = ImageSource.FromFile("sunny_cloud.png");
        private static readonly ImageSource _imageSnow = ImageSource.FromFile("snow_rain.png");

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
                case WeatherCondition.suncloud:
                    return _imageSunCloud;
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
