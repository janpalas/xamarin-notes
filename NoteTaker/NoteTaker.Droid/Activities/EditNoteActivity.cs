using Android.App;
using Android.OS;
using Android.Views;

namespace NoteTaker.Droid.Activities
{
    [Activity(Label = "EditNoteActivity", ParentActivity = typeof(NotesListActivity))]
    public class EditNoteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActivateActionBar();

            // Create your application here
            SetContentView (Resource.Layout.EditNote);
        }

        private void ActivateActionBar()
        {
            RequestWindowFeature(WindowFeatures.ActionBar);

            ActionBar.NavigationMode = ActionBarNavigationMode.Standard;
            ActionBar.SetTitle(Resource.String.EditNoteActionBarTitle);
            ActionBar.SetDisplayShowTitleEnabled(true);

            //Enabluje moznost prechodu "UP" z hlavicky v menu - proto je nutne v atributu tridy uvest ParentActivity
            ActionBar.SetDisplayHomeAsUpEnabled(true);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.EditNoteMenu, menu);
            return true;
        }
    }
}