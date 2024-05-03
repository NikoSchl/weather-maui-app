using System.Diagnostics;
using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class DailyForecastPage : ContentPage
{
    private const string TomorrowForecastPageRouteBase = $"{nameof(TomorrowForecastPage)}";

    private readonly DailyForecastViewModel _viewModel;
	public DailyForecastPage()
	{
		InitializeComponent();
        _viewModel = new DailyForecastViewModel();
        BindingContext = _viewModel;

        Debug.WriteLine("Created DailyForecastPage");

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.InitializeData();
        Debug.WriteLine("OnAppering DailyForecastPage");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _viewModel.CleanUpData();
        Debug.WriteLine("OnDisappering DailyForecastPage");
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(TomorrowForecastPageRouteBase);
    }
}