using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using NoteTaker.Shared.Models;
using NoteTaker.Shared.ViewModels.Page;

namespace NoteTaker.Droid.Activities
{
    [Activity(Label = "EditNoteActivity", ParentActivity = typeof(NotesListActivity))]
    public class EditNoteActivity : Activity
    {
        private EditNotePageViewModel _viewModel;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActivateActionBar();
            SetContentView(Resource.Layout.EditNote);

            _viewModel = new EditNotePageViewModel(new TestNotesManager());

            string noteGuid = Intent.GetStringExtra("NoteGUID");
            _viewModel.LoadData(!string.IsNullOrEmpty(noteGuid) ? Guid.Parse(noteGuid) : (Guid?) null);

            if (!string.IsNullOrEmpty(noteGuid))
            {
                DisplayDataInView();
            }
            else
            {
                ActionBar.SetTitle(Resource.String.NewNoteActionBarTitle);
            }
        }

        private void DisplayDataInView()
        {
            FindViewById<TextView>(Resource.Id.txtTitle).Text = _viewModel.Note.Title;
            FindViewById<TextView>(Resource.Id.txtNote).Text = _viewModel.Note.NoteText;
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