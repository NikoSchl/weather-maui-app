using WeatherApp.Views;

namespace WeatherApp
{
    public partial class AppShell : Shell
    {
        private const string TodayDetailPageRouteBase = $"{nameof(TodayDetailPage)}";
        public const string TodayDetailPageRoute = $"///{TodayDetailPageRouteBase}";
        private const string SevenDaysPageRouteBase = $"{nameof(MainPage)}/{nameof(TodayDetailPage)}";

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(TodayDetailPageRouteBase, typeof(TodayDetailPage));
            Routing.RegisterRoute("sevenDayPageRoute", typeof(SevenDaysPreviewPage));
        }
    }
}
