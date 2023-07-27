﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperHeroApi.Data;

#nullable disable

namespace SuperHeroApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("SuperHeroApi.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("793e6f3f-9f2b-42ff-9fd0-3f6497fc8e87"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("ff2b2975-003d-453f-81a0-a9638f9d56f3"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("44fe3768-3dbf-45e2-a6cd-6ddcc507ea78"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("3f2bf09a-78bd-41cc-8bde-155e8bf31f93"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("16410ff3-dd01-4645-b0d3-422a9e1e3440"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("66076200-33b6-423a-9590-5d5aaf38f022"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("16410ff3-dd01-4645-b0d3-422a9e1e3440"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("4b03023a-0f6a-4b62-979b-06be5e7718e6"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("16410ff3-dd01-4645-b0d3-422a9e1e3440"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("12596836-6a98-487c-b534-ece9654877b5"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("3549316e-dc54-4af5-a805-0f7a05db40bc"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("SuperHeroApi.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Height")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = 1.9299999999999999,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("16410ff3-dd01-4645-b0d3-422a9e1e3440"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = 1.7,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("3549316e-dc54-4af5-a805-0f7a05db40bc"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = 1.7,
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("SuperHeroApi.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c5b97831-dd0a-4fc7-855b-fb9de5c33b29"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552")
                        },
                        new
                        {
                            Id = new Guid("5ee63dff-c6a2-4340-a679-64b811b6ee8b"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552")
                        },
                        new
                        {
                            Id = new Guid("2271da05-aadd-420a-92af-00eb3068df9e"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("bf8d321b-0247-4478-ba9d-7d4ebf107552")
                        },
                        new
                        {
                            Id = new Guid("409dc5af-740f-4c09-9f33-307ea0b6b948"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("16410ff3-dd01-4645-b0d3-422a9e1e3440")
                        },
                        new
                        {
                            Id = new Guid("4bdbdbbc-3601-4e88-a14a-d7771ac9ce9d"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("3549316e-dc54-4af5-a805-0f7a05db40bc")
                        },
                        new
                        {
                            Id = new Guid("a8cbca0d-9dcc-40fd-9177-a1d907a2f278"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("3549316e-dc54-4af5-a805-0f7a05db40bc")
                        },
                        new
                        {
                            Id = new Guid("f4d700db-c2b7-4084-abbd-69373e455d3f"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("3549316e-dc54-4af5-a805-0f7a05db40bc")
                        });
                });

            modelBuilder.Entity("SuperHeroApi.Models.Movie", b =>
                {
                    b.HasOne("SuperHeroApi.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("SuperHeroApi.Models.Superpower", b =>
                {
                    b.HasOne("SuperHeroApi.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("SuperHeroApi.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
