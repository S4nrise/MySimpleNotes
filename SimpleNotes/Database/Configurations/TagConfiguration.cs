using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleNotes.Models.Tag;

namespace SimpleNotes.Database.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(tag => tag.Id);
            //builder
            //    .HasMany(tag => tag.Notes)
            //    .WithMany(note => note.Tags);
        }
    }
}
