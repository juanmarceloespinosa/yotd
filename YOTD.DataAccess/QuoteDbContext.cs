using System;
using System.Globalization;
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

             builder.Entity<Quote>().HasData(
                new Quote
                {
                    Id = 1,
                    Text = "It’s not my fault.",
                    Author = "Han Solo",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 2,
                    Text = "Your focus determines your reality.",
                    Author = "Qui-Gon Jinn",
                    Date = DateTime.ParseExact("1999-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    Category = null
                },
                new Quote
                {
                    Id = 3,
                    Text = "Do. Or do not. There is no try.",
                    Author = "Yoda",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    Category = null
                },
                new Quote
                {
                    Id = 4,
                    Text = "Somebody has to save our skins.",
                    Author = "Leia Organa",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 5,
                    Text = "In my experience there is no such thing as luck.",
                    Author = "Obi-Wan Kenobi",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    Category = null
                },
                new Quote
                {
                    Id = 6,
                    Text = "I find your lack of faith disturbing.",
                    Author = "Darth Vader",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 2,
                    Category = null
                },
                new Quote
                {
                    Id = 7,
                    Text = "I’ve got a bad feeling about this",
                    Author = "basically everyone",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 8,
                    Text = "It’s a trap!",
                    Author = "Admiral Ackbar",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 9,
                    Text = "So this is how liberty dies... with thunderous applause.",
                    Author = "Padmé Amidala",
                    Date = DateTime.ParseExact("1999-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 10,
                    Text = "Your eyes can deceive you. Don’t trust them.",
                    Author = "Obi-Wan Kenobi",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    Category = null
                },
                new Quote
                {
                    Id = 11,
                    Text = "Never tell me the odds.",
                    Author = "Han Solo",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 12,
                    Text = "Mind tricks don’t work on me.",
                    Author = "Watto",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 13,
                    Text = "Great, kid. Don’t get cocky.",
                    Author = "Han Solo",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 3,
                    Category = null
                },
                new Quote
                {
                    Id = 14,
                    Text = "Stay on target.",
                    Author = "Gold Five",
                    Date = DateTime.ParseExact("1977-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    Category = null
                },
                new Quote
                {
                    Id = 15,
                    Text = "This is a new day, a new beginning.",
                    Author = "Ahsoka Tano",
                    Date = DateTime.ParseExact("2008-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CategoryId = 1,
                    Category = null
                }
             );
        }
    }
}
