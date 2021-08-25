using Microsoft.EntityFrameworkCore;
using DevChallenge.Data.Entities;
using System.Text.Json;
using System.Collections.Generic;

namespace DevChallenge.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {
            }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)            
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .Property(p => p.Authors)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, default),
                    v => JsonSerializer.Deserialize<List<string>>(v, default));
        }
            
    }
}