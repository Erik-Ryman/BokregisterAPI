using BokregisterAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BokregisterAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Book>()
                .HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        ISBN = "9780743273565"
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "The Catcher in the Rye",
                        Author = "J.D. Salinger",
                        ISBN = "9780316769488"
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        ISBN = "9780061120084"
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "1984",
                        Author = "George Orwell",
                        ISBN = "9780451524935"
                    }
                );
        }

        public DbSet<Book> Books { get; set; } = default!;
    }
}
