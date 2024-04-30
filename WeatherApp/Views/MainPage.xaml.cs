using System.Diagnostics;
using WeatherApp.ViewModels;

namespace WeatherApp.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            BindingContext = _viewModel;

            Debug.WriteLine("Created Mainpage");

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.InitializeData();
            Debug.WriteLine("OnAppering Mainpage");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            //_viewModel.CleanUpData();
            Debug.WriteLine("OnDisappering Mainpage");

        }
    }
}
