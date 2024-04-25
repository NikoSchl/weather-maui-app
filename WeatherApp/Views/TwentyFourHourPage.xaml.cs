using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class TwentyFourHourPage : ContentPage
{
	private readonly TwentyFourHourViewModel _viewModel = new TwentyFourHourViewModel();
	public TwentyFourHourPage()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}
}