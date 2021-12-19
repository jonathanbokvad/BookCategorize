using BookCategorize.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCategorize.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        public DbSet<SearchBookModel> searchBookModels { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Volumeinfo> Volumeinfo { get; set; }
        public DbSet<Searches> Searches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Volumeinfo>()
            .Property(e => e.authors)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
    }
} 