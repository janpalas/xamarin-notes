using Android.App;
using Android.OS;
using Android.Views;

namespace NoteTaker.Droid.Activities
{
    [Activity(Label = "NotesListActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class NotesListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            ActivateActionBar();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.NotesListMenu, menu);
            return true;
        }

        private void ActivateActionBar()
        {
            RequestWindowFeature(WindowFeatures.ActionBar);

            ActionBar.NavigationMode = ActionBarNavigationMode.Standard;
            ActionBar.SetTitle(Resource.String.MyNotesActionBarTitle);
            ActionBar.SetDisplayShowTitleEnabled(true);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.AddMenuItem)
            {
                StartActivity(typeof(EditNoteActivity));    
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}