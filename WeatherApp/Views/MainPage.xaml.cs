using WeatherApp.ViewModels;

namespace WeatherApp.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _viewModel = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }

    }
}
