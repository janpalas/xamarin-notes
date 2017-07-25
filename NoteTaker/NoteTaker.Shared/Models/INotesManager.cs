using System;
using System.Collections.Generic;

namespace NoteTaker.Shared.Models
{
    public interface INotesManager
    {
        List<Note> GetNotes();

        Note GetNote(Guid noteGUID);

        void InsertNote(Note note);

        void UpdateNote(Note note);

        void DeleteNote(Note note);
    }
}
