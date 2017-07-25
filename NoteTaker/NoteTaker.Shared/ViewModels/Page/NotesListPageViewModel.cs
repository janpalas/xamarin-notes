using System.Collections.ObjectModel;
using NoteTaker.Shared.Models;

namespace NoteTaker.Shared.ViewModels.Page
{
    public class NotesListPageViewModel
    {
        private readonly INotesManager _notesManager;

        public ObservableCollection<Note> Notes { get; set; }

        public NotesListPageViewModel(INotesManager notesManager)
        {
            _notesManager = notesManager;
        }

        public void LoadNotes()
        {
            Notes = new ObservableCollection<Note>(_notesManager.GetNotes());
        }
    }
}
