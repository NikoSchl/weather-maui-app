using System.Diagnostics;
using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class TwentyFourHourPage : ContentPage
{
	private readonly TwentyFourHourViewModel _viewModel;
	public TwentyFourHourPage()
	{
		InitializeComponent();
        _viewModel = new TwentyFourHourViewModel();
        BindingContext = _viewModel;

        Debug.WriteLine("Created TwentyFourHourPage");

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.InitializeData();
        Debug.WriteLine("OnAppering TwentyFourHourPage");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
       // _viewModel.CleanUpData();
        Debug.WriteLine("OnDisappering TwentyFourHourPage");
    }
}