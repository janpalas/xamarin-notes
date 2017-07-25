﻿using Android.App;
using Android.OS;
using Android.Views;
using NoteTaker.Droid.Adapters;
using NoteTaker.Shared.Models;
using NoteTaker.Shared.ViewModels.Page;

namespace NoteTaker.Droid.Activities
{
    [Activity(Label = "NotesListActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class NotesListActivity : ListActivity
    {
        private NotesListPageViewModel _viewModel;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActivateActionBar();

            _viewModel = new NotesListPageViewModel(new TestNotesManager());
            _viewModel.LoadNotes();

            ListAdapter = new NotesAdapter(this, _viewModel.Notes);
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