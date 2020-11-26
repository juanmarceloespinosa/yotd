﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YOTD.DataAccess;

namespace YOTD.WebApi.Migrations
{
    [DbContext(typeof(QuoteDbContext))]
    [Migration("20201126045221_QuoteUpdates")]
    partial class QuoteUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("YOTD.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "The Force"
                        },
                        new
                        {
                            Id = 2,
                            Name = "The Dark Side"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Misc"
                        });
                });

            modelBuilder.Entity("YOTD.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Quote");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Han Solo",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "It’s not my fault."
                        },
                        new
                        {
                            Id = 2,
                            Author = "Qui-Gon Jinn",
                            CategoryId = 1,
                            Date = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Your focus determines your reality."
                        },
                        new
                        {
                            Id = 3,
                            Author = "Yoda",
                            CategoryId = 1,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Do. Or do not. There is no try."
                        },
                        new
                        {
                            Id = 4,
                            Author = "Leia Organa",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Somebody has to save our skins."
                        },
                        new
                        {
                            Id = 5,
                            Author = "Obi-Wan Kenobi",
                            CategoryId = 1,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "In my experience there is no such thing as luck."
                        },
                        new
                        {
                            Id = 6,
                            Author = "Darth Vader",
                            CategoryId = 2,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "I find your lack of faith disturbing."
                        },
                        new
                        {
                            Id = 7,
                            Author = "basically everyone",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "I’ve got a bad feeling about this"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Admiral Ackbar",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "It’s a trap!"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Padmé Amidala",
                            CategoryId = 3,
                            Date = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "So this is how liberty dies... with thunderous applause."
                        },
                        new
                        {
                            Id = 10,
                            Author = "Obi-Wan Kenobi",
                            CategoryId = 1,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Your eyes can deceive you. Don’t trust them."
                        },
                        new
                        {
                            Id = 11,
                            Author = "Han Solo",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Never tell me the odds."
                        },
                        new
                        {
                            Id = 12,
                            Author = "Watto",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Mind tricks don’t work on me."
                        },
                        new
                        {
                            Id = 13,
                            Author = "Han Solo",
                            CategoryId = 3,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Great, kid. Don’t get cocky."
                        },
                        new
                        {
                            Id = 14,
                            Author = "Gold Five",
                            CategoryId = 1,
                            Date = new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "Stay on target."
                        },
                        new
                        {
                            Id = 15,
                            Author = "Ahsoka Tano",
                            CategoryId = 1,
                            Date = new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Text = "This is a new day, a new beginning."
                        });
                });

            modelBuilder.Entity("YOTD.Models.Quote", b =>
                {
                    b.HasOne("YOTD.Models.Category", "Category")
                        .WithMany("Quotes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YOTD.Models.Category", b =>
                {
                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
