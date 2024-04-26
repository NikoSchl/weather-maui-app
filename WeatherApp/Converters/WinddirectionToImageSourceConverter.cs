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
            Winddirection winddirection = (Winddirection)value!;

            switch (winddirection)
            {
                case Winddirection.north:
                    return _north;
                case Winddirection.south:
                    return _south;
                case Winddirection.west:
                    return _east;
                case Winddirection.east:
                    return _west;
                case Winddirection.northwest:
                    return _north_west;
                case Winddirection.northeast:
                    return _north_east;
                case Winddirection.southeast:
                    return _south_east;
                case Winddirection.southwest:
                    return _south_west;
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
