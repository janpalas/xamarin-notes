using System;
using NoteTaker.Shared.Models;

namespace NoteTaker.Shared.ViewModels.Page
{
    public class EditNotePageViewModel
    {
        private readonly INotesManager _notesManager;

        public Note Note { get; set; }

        public EditNotePageViewModel(INotesManager notesManager)
        {
            _notesManager = notesManager;
        }

        public void LoadData(Guid? guid)
        {
            if (guid.HasValue)
            {
                Note = _notesManager.GetNote(guid.Value);
            }
            
            if (Note == null)
            {
               Note = new Note(); 
            }
        }

        public void SaveChanges()
        {
            if (Note.NoteGUID.HasValue)
            {
                _notesManager.InsertNote(Note);
            }
            else
            {
                _notesManager.UpdateNote(Note);
            }
        }
    }
}
