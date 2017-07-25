using System;
using System.Collections.Generic;
using System.Linq;

namespace NoteTaker.Shared.Models
{
    public class TestNotesManager : INotesManager
    {
        private static List<Note> _notes;

        public TestNotesManager()
        {
            if (_notes == null)
            {
                _notes = new List<Note>
                {
                    new Note { NoteGUID = Guid.NewGuid(), Title = "Poznámka 1", NoteText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Created = new DateTime(2017, 5, 30, 17, 15, 6)},
                    new Note { NoteGUID = Guid.NewGuid(), Title = "Poznámka 2", NoteText = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Created = new DateTime(2017, 6, 24, 18, 12, 3)},
                    new Note { NoteGUID = Guid.NewGuid(), Title = "Poznámka 3", NoteText = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Created = new DateTime(2017, 7, 3, 7, 17, 52)}
                };
            }    
        }

        public List<Note> GetNotes()
        {
            return _notes;
        }

        public Note GetNote(Guid noteGUID)
        {
            return _notes.FirstOrDefault(x => x.NoteGUID == noteGUID);
        }

        public void InsertNote(Note note)
        {
            _notes.Add(note);
        }

        public void UpdateNote(Note note)
        {
        }

        public void DeleteNote(Note note)
        {
            _notes.Remove(note);
        }
    }
}
