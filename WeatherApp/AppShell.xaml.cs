using WeatherApp.Views;

namespace WeatherApp
{
    public partial class AppShell : Shell
    {
        public const string CreateTomorrowForecastPageRoute = $"{nameof(TomorrowForecastPage)}";
        public const string TomorrowForecastPageRoute = $"///{CreateTomorrowForecastPageRoute}";

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(CreateTomorrowForecastPageRoute, typeof(TomorrowForecastPage));
        }
    }
}
