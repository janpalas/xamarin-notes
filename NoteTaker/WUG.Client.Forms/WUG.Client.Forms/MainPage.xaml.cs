using WUG.Client.Shared.Models;
using WUG.Client.Shared.PlatformAbstractions;
using WUG.Client.Shared.ViewModels.Entity;
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

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Ahoj", "bla bla bla", "Storno");

            var eventInfo = e.Item as EventInfoViewModel;
            if (eventInfo != null)
            {
                await Navigation.PushAsync(new EventDetailPage(eventInfo));
            }
        }
    }
}
