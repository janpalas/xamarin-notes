using WUG.Client.Shared.Models;
using WUG.Client.Shared.PlatformAbstractions;
using WUG.Client.Shared.ViewModels.Page;
using Xamarin.Forms;

namespace WUG.Client.Forms
{
    public partial class MainPage
    {
        private readonly MainPageViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new MainPageViewModel(new EventProvider(DependencyService.Get<IWebClient>()));
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _viewModel.LoadDataAsync();
        }
    }
}
