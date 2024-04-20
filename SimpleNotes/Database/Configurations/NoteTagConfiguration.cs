using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleNotes.Models.Tag;

namespace SimpleNotes.Database.Configurations
{
    public class NoteTagConfiguration : IEntityTypeConfiguration<NoteTag>
    {
        public void Configure(EntityTypeBuilder<NoteTag> builder)
        {
            builder.HasKey(noteTag => new {noteTag.NoteId,noteTag.TagId});
            builder
                .HasOne(noteTag => noteTag.Tag)
                .WithMany(tag => tag.NoteTags)
                .HasForeignKey(noteTag => noteTag.TagId)
                .IsRequired();

            builder
                .HasOne(noteTag => noteTag.Note)
                .WithMany(note => note.NoteTags)
                .HasForeignKey(noteTag => noteTag.NoteId)
                .IsRequired();
        }
    }
}
