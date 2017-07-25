using System.Collections.ObjectModel;
using System.Globalization;
using Android.Content;
using Android.Views;
using Android.Widget;
using NoteTaker.Shared.Models;

namespace NoteTaker.Droid.Adapters
{
    public class NotesAdapter : BaseAdapter<Note>
    {
        private readonly ObservableCollection<Note> _notes;
        private readonly LayoutInflater _inflater;

        public NotesAdapter(Context context, ObservableCollection<Note> notes)
        {
            _notes = notes;
            _inflater = LayoutInflater.From(context);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (_notes != null)
            {
                view = _inflater.Inflate(Resource.Layout.NoteListViewItem, parent, false);

                TextView date = view.FindViewById<TextView>(Resource.Id.textViewCreated);
                TextView title = view.FindViewById<TextView>(Resource.Id.textViewTitle);

                date.Text = _notes[position].Created.ToString(CultureInfo.CurrentCulture);
                title.Text = _notes[position].Title;
            }

            return view;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count => _notes?.Count ?? 0;

        public override Note this[int position] => _notes[position];
    }
}