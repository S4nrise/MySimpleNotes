using Microsoft.EntityFrameworkCore;
using SimpleNotes.Abstract;
using SimpleNotes.Database.Configurations;
using SimpleNotes.Models.Note;
using SimpleNotes.Models.Tag;
using SimpleNotes.Models.User;

namespace SimpleNotes.Database;

public class SimpleNotesDbContext : DbContext, ISimpleNotesDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Tag> Tags{ get; set; }
    public DbSet<NoteTag> NoteTag{ get; set; }
    
    public SimpleNotesDbContext(DbContextOptions<SimpleNotesDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new NoteConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TagConfiguration());
        modelBuilder.ApplyConfiguration(new NoteTagConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}