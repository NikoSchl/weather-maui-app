using WeatherApp.Views;

namespace WeatherApp
{
    public partial class AppShell : Shell
    {
        private const string TodayDetailPageRouteBase = $"{nameof(SevenDaysPreviewPage)}/{nameof(TodayDetailPage)}";
        public const string TodayDetailPageRoute = $"///{TodayDetailPageRouteBase}";
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(TodayDetailPageRouteBase, typeof(TodayDetailPage));
        }
    }
}
