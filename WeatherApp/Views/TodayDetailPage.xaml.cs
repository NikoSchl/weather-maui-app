using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class TodayDetailPage : ContentPage
{
	private readonly TodayDetailViewModel _viewModel = new TodayDetailViewModel();
	public TodayDetailPage()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}
}