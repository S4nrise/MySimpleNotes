namespace SimpleNotes.Models.Tag
{
    public class NoteTag
    {
        public Guid NoteId { get; }
        public Guid TagId { get; }
        public Note.Note Note { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
    }
}
