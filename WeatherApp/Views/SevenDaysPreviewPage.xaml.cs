using System.Diagnostics;
using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class SevenDaysPreviewPage : ContentPage
{
    private const string TodayDetailPageRouteBase = $"{nameof(TodayDetailPage)}";

    private readonly SevenDayViewModel _viewModel;
	public SevenDaysPreviewPage()
	{
		InitializeComponent();
        _viewModel = new SevenDayViewModel();
        BindingContext = _viewModel;

        Debug.WriteLine("Created SevenDaysPreviewPage");

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.InitializeData();
        Debug.WriteLine("OnAppering SevenDaysPreviewPage");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _viewModel.CleanUpData();
        Debug.WriteLine("OnDisappering SevenDaysPreviewPage");
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(TodayDetailPageRouteBase);
    }
}