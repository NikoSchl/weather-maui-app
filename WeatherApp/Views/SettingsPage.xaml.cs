using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class SettingsPage : ContentPage
{
    private readonly SettingsViewModel _viewModel;

    public SettingsPage()
	{
		InitializeComponent();
        _viewModel = new SettingsViewModel();
        BindingContext = _viewModel;
	}
}