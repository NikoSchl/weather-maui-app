using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class TodayDetailPage : ContentPage
{
	private readonly TodayDetailViewModel _viewModel;
	public TodayDetailPage()
	{
		InitializeComponent();
        _viewModel = new TodayDetailViewModel();
        BindingContext = _viewModel;
	}
}