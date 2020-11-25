using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using YOTD.Models;

namespace YOTD.DataAccess
{
    public class QuoteDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Category> Categories { get; set; }

        public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                //base.OnModelCreating(builder);
                entityType.SetTableName(entityType.DisplayName());
            }

            builder.Entity<Category>().HasData(
        
                new Category
                {
                    Id = 1,
                    Name = "The Force"
                },
                new Category
                {
                    Id = 2,
                    Name = "The Dark Side"
                },
                new Category
                {
                    Id = 3,
                    Name = "Misc"
                }
            );
        }
    }
}
