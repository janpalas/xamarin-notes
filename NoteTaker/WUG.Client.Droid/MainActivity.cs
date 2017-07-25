using Android.App;
using Android.OS;
using WUG.Client.Droid.Adapters;
using WUG.Client.Droid.PlatformSpecific;
using WUG.Client.Shared.Models;
using WUG.Client.Shared.ViewModels.Page;

namespace WUG.Client.Droid
{
    [Activity(Label = "WUG.Client.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        private MainPageViewModel _viewModel;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            _viewModel = new MainPageViewModel(new EventProvider(new DroidHttpClient()));
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        protected override async void OnStart()
        {
            base.OnStart();

            await _viewModel.LoadDataAsync();
            ListAdapter = new EventInfosAdapter(this, _viewModel.UpcomingEvents);
        }
    }
}

