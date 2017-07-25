using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
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
        }

        protected override void OnStart()
        {
            base.OnStart();

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

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            Note note = _viewModel.Notes[position];

            var noteDetail = new Intent(this, typeof(EditNoteActivity));
            noteDetail.PutExtra("NoteGUID", note.NoteGUID.ToString());

            StartActivity(noteDetail);
        }
    }
}