using System;

namespace NoteTaker.Shared.Models
{
    public class Note
    {
        public Guid? NoteGUID { get; set; }

        public string Title { get; set; }

        public string NoteText { get; set; }

        public DateTime Created { get; set; }
    }
}
