using Microsoft.EntityFrameworkCore;
using NotesApp.Model;
using NotesApp.Models;
namespace NotesApp.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Note> Notes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Note>()
            .HasOne(n => n.Category)
            .WithMany(c => c.Notes)
            .HasForeignKey(n => n.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Note>()
        .HasIndex(n => n.Category);

        modelBuilder.Entity<Note>()
        .HasIndex(n => n.CreatedAt);

        modelBuilder.Entity<Category>().HasData(
new Category
        )
    }
}