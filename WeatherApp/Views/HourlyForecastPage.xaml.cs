using System.Diagnostics;
using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class HourlyForecastPage : ContentPage
{
	private readonly HourlyForecastViewModel _viewModel;
	public HourlyForecastPage()
	{
		InitializeComponent();
        _viewModel = new HourlyForecastViewModel();
        BindingContext = _viewModel;

        Debug.WriteLine("Created HourlyForecastPage");

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.InitializeData();
        Debug.WriteLine("OnAppering HourlyForecastPage");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _viewModel.CleanUpData();
        Debug.WriteLine("OnDisappering HourlyForecastPage");
    }
}