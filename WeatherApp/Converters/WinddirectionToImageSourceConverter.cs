using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.Collections;
using System.Threading.Tasks;
using System.Globalization;

namespace WeatherApp.Converters
{
    public class WinddirectionToImageSourceConverter : IValueConverter
    {
        private static readonly ImageSource _north = ImageSource.FromFile("north.png");
        private static readonly ImageSource _south = ImageSource.FromFile("south.png");
        private static readonly ImageSource _east = ImageSource.FromFile("east.png");
        private static readonly ImageSource _west = ImageSource.FromFile("west.png");
        private static readonly ImageSource _north_west = ImageSource.FromFile("north_west.png");
        private static readonly ImageSource _north_east = ImageSource.FromFile("north_east.png");
        private static readonly ImageSource _south_west = ImageSource.FromFile("south_west.png");
        private static readonly ImageSource _south_east = ImageSource.FromFile("south_east.png");

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // The incoming value must be converted from an object into the value we need,
            // in this case an enum which determines the wind direction. Because the value
            // can never be zero, you don't need an if(). Conversion can be secured with (!)

            Winddirection winddirection = (Winddirection)value!;


            // The switch handles all cases from the enum and determines
            // which value (image) must be returned

            switch (winddirection)
            {
                case Winddirection.north:
                    return _north;
                case Winddirection.northeast:
                    return _north_east;
                case Winddirection.east:
                    return _east;
                case Winddirection.southeast:
                    return _south_east;
                case Winddirection.south:
                    return _south;
                case Winddirection.southwest:
                    return _south_west;
                case Winddirection.west:
                    return _west;
                case Winddirection.northwest:
                    return _north_west;
                default:
                    return _north;
            }
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
