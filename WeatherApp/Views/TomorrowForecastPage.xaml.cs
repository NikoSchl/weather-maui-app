using System.Diagnostics;
using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class TomorrowForecastPage : ContentPage
{
	private readonly TomorrowForecastViewModel _viewModel;

	public TomorrowForecastPage()
	{
		InitializeComponent();
        _viewModel = new TomorrowForecastViewModel();
        BindingContext = _viewModel;

        Debug.WriteLine("Created TomorrowForecastPage");

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.InitializeData();
        Debug.WriteLine("OnAppering TomorrowForecastPage");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Debug.WriteLine("OnDisappering TomorrowForecastPage");
    }

}