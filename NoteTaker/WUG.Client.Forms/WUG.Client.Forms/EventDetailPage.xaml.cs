using WUG.Client.Shared.ViewModels.Entity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WUG.Client.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventDetailPage : ContentPage
    {
        private readonly EventInfoViewModel _viewModel;

        public EventDetailPage(EventInfoViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            BindingContext = _viewModel;
        }
    }
}