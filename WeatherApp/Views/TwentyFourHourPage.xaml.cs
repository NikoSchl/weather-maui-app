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
	}
}