namespace SimpleNotes.Models.Tag
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        //public List<Note.Note> Notes { get; } = [];
        public List<NoteTag> NoteTags { get; } = [];
    }
}
