using WeatherApp.Views;

namespace WeatherApp
{
    public partial class AppShell : Shell
    {
        public const string CreateDetailPageRoute = $"{nameof(TodayDetailPage)}";
        public const string TodayDetailPageRoute = $"///{CreateDetailPageRoute}";
        public const string SevenDaysPageRouteBase = $"{nameof(MainPage)}/{nameof(TodayDetailPage)}";

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(CreateDetailPageRoute, typeof(TodayDetailPage));
            Routing.RegisterRoute("sevenDayPageRoute", typeof(SevenDaysPreviewPage));
        }
    }
}
