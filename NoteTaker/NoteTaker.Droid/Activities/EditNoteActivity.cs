using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NoteTaker.Droid.Activities
{
    [Activity(Label = "EditNoteActivity", MainLauncher = true, Icon = "@drawable/icon")]
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
            ActionBar.SetDisplayHomeAsUpEnabled(true);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.EditNoteMenu, menu);
            return true;
        }
    }
}