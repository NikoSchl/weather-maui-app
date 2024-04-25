using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class SevenDaysPreviewPage : ContentPage
{
    private const string TodayDetailPageRouteBase = $"{nameof(TodayDetailPage)}";

    private readonly SevenDayViewModel _viewModel = new SevenDayViewModel();
	public SevenDaysPreviewPage()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(TodayDetailPageRouteBase);
    }
}