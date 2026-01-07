using Microsoft.EntityFrameworkCore;
using RestApi.Models;
namespace RestApi.Data
{
    public class FirstApiContext : DbContext
    {
        public FirstApiContext(DbContextOptions<FirstApiContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "1984",
                    Author = "George Orwell",
                    YearPublished = "1949"
                },
            new Book
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                YearPublished = "1960"
            },
            new Book
            {
                Id = 3,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                YearPublished = "1925"
            },
            new Book
            {
                Id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                YearPublished = "1813"
            }
                );
        }
        public DbSet<Book> Books { get; set; } = null!;
    }
}
