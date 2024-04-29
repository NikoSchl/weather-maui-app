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
        private static readonly ImageSource _imageThunder = ImageSource.FromFile("gewitter_wolke.png");
        private static readonly ImageSource _imageSnow = ImageSource.FromFile("snow_rain.png");

        private static readonly ImageSource _imageSunrise = ImageSource.FromFile("sunrise_sun.png");
        private static readonly ImageSource _imageSunset = ImageSource.FromFile("sunset_sun.png");

        private static readonly ImageSource _imageMoon = ImageSource.FromFile("moon.png");
        private static readonly ImageSource _imageNightCloud = ImageSource.FromFile("moon_cloud.png");
        private static readonly ImageSource _imageNightRain = ImageSource.FromFile("night_rain.png");

        // Converter von ViewModel zu View
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // Das was reinkommt, ist immer ein Objekt und muss immer in das konvertiert werden was wir
            // nutzen wollen, in diesem Fall ein enum in dem die Wetterlagen (sonnig, ...) drin stehen

            // Das (object) kann null sein (?), weshalb dieser Fall mit einem if und Standardwert abgefangen
            // werden muss. Durch das enum wissen wir aber, das in diesem Fall es niemals null sein wird
            // und kann deshalb wegfallen und bei der Konvertierung mit eine (!) definiert werden

            WeatherCondition condition = (WeatherCondition)value!;


            // Im switch werden die Werte welche im enum liegen durchgegangen und bestimmt, was
            // (welches Bild) zurückgegeben wird. Steht die condition (das enum) auf sunny, dann
            // gib das Bild (Speicherplatz) mit der Sonne zurück

            switch (condition)
            {
                // erster Fall (case) ist identisch mit:
                // if(WeatherCondition.sunny)
                // { WeatherCondition condition = _imageSunny }

                case WeatherCondition.sunny:
                    return _imageSunny;
                case WeatherCondition.rain:
                    return _imageRain;
                case WeatherCondition.cloudy:
                    return _imageCloudy;
                case WeatherCondition.suncloud:
                    return _imageSunCloud;
                case WeatherCondition.thunder:
                    return _imageThunder;
                case WeatherCondition.snow:
                    return _imageSnow;
                case WeatherCondition.sunrise:
                    return _imageSunrise;
                case WeatherCondition.sunset:
                    return _imageSunset;
                case WeatherCondition.moon:
                    return _imageMoon;
                case WeatherCondition.nightcloud:
                    return _imageNightCloud;
                case WeatherCondition.nightrain:
                    return _imageNightRain;
                default:
                    return _imageSunny;
            }
        }


        // Converter von View zurück in ViewModel
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
