﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230211161630_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Auth", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("Salt")
                        .HasMaxLength(1000)
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.HasIndex("Salt")
                        .IsUnique();

                    b.ToTable("Auth", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Login = "admin@email.com",
                            Password = "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK+u88gtSXAyPDkW+hVS+dW4AmxrnaNFZks0Zzcd5xlb12wcF/q96cc4htHFzvOH9jtN98N5EBIXSvdUVnFc9kBuRTVytATZA7gITbs//hkxvNQ3eody5U9hjdH6D+AP0vVt5unZlTZ+gInn8Ze7AC5o6mn0Y3ylGO1CBJSHU9c/BcFY9oknn+XYk9ySCoDGctMqDbvOBcvSTBkKcrCzev2KnX7xYmC3yNz1Q5oPVKgnq4mc1iuldMlCxse/IDGMJB2FRdTCLV5KNS4IZ1GB+dw3tMvcEEtmXmgT2zKN5+kUkOxhlv5g1ZLgXzWjVJeKb5uZpsn3WK5kt8T+kzMoxHd5i8HxsU2uvy9GopxAnaV0WNsBPqTGkRllSxARl4ZN3hJqUla553RT49tJxbs+N03OmkYhjq+L0aKJ1AC+7G+rdjegiAQZB+3mdE7a2Pne2kYtpMoCmNMKdm9jOOVpfXJqZMQul9ltJSlAY6LPrHFUB3mw61JBNzx+sZgYN29GfDY=",
                            Salt = new Guid("79005744-e69a-4b09-996b-08fe0b70cbb9")
                        });
                });

            modelBuilder.Entity("Domain.Film", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Actors")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Plot")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Film", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Actors = "Chris Pratt, Zoe Saldana, Dave Bautista",
                            Country = "United States",
                            Genre = "Action, Adventure, Comedy",
                            Language = "English",
                            Plot = "The Guardians struggle to keep together as a team while dealing with their personal family issues, notably Star-Lord's encounter with his father the ambitious celestial being Ego",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNjM0NTc0NzItM2FlYS00YzEwLWE0YmUtNTA2ZWIzODc2OTgxXkEyXkFqcGdeQXVyNTgwNzIyNzg@._V1_SX300.jpg",
                            Title = "Guardians of the Galaxy Vol. 2",
                            Year = 2017
                        },
                        new
                        {
                            Id = 2L,
                            Actors = "Tim Robbins, Morgan Freeman, Bob Gunton",
                            Country = "United States",
                            Genre = "Drama",
                            Language = "English",
                            Plot = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg",
                            Title = "The Shawshank Redemption",
                            Year = 1994
                        },
                        new
                        {
                            Id = 3L,
                            Actors = "Marlon Brando, Al Pacino, James Caan",
                            Country = "United States",
                            Genre = "Crime, Drama",
                            Language = "English, Italian, Latin",
                            Plot = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "The Godfather",
                            Year = 1972
                        },
                        new
                        {
                            Id = 4L,
                            Actors = "Al Pacino, Robert De Niro, Robert Duvall",
                            Country = "United States",
                            Genre = "Crime, Drama",
                            Language = "English, Italian, Spanish, Latin, Sicilian",
                            Plot = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "The Godfather: Part II",
                            Year = 1974
                        },
                        new
                        {
                            Id = 5L,
                            Actors = "Christian Bale, Heath Ledger, Aaron Eckhart",
                            Country = "United States, United Kingdom",
                            Genre = "Action, Crime, Drama",
                            Language = "English, Mandarin",
                            Plot = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SX300.jpg",
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            Id = 6L,
                            Actors = "Henry Fonda, Lee J. Cobb, Martin Balsam",
                            Country = "United States",
                            Genre = "Crime, Drama",
                            Language = "English",
                            Plot = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SX300.jpg",
                            Title = "12 Angry Men",
                            Year = 1957
                        },
                        new
                        {
                            Id = 7L,
                            Actors = "Liam Neeson, Ralph Fiennes, Ben Kingsley",
                            Country = "United States",
                            Genre = "Biography, Drama, History",
                            Language = "English, Hebrew, German, Polish, Latin",
                            Plot = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                            Title = "Schindler's List",
                            Year = 1993
                        },
                        new
                        {
                            Id = 8L,
                            Actors = "Elijah Wood, Viggo Mortensen, Ian McKellen",
                            Country = "New Zealand, United States",
                            Genre = "Action, Adventure, Drama",
                            Language = "English, Quenya, Old English, Sindarin",
                            Plot = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "The Lord of the Rings: The Return of the King",
                            Year = 2003
                        },
                        new
                        {
                            Id = 9L,
                            Actors = "John Travolta, Uma Thurman, Samuel L. Jackson",
                            Country = "United States",
                            Genre = "Crime, Drama",
                            Language = "English, Spanish, French",
                            Plot = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            Id = 10L,
                            Actors = "Clint Eastwood, Eli Wallach, Lee Van Cleef",
                            Country = "Italy, Spain, West Germany",
                            Genre = "Adventure, Western",
                            Language = "Italian, English",
                            Plot = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNjJlYmNkZGItM2NhYy00MjlmLTk5NmQtNjg1NmM2ODU4OTMwXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg",
                            Title = "The Good, the Bad and the Ugly",
                            Year = 1966
                        },
                        new
                        {
                            Id = 11L,
                            Actors = "Brad Pitt, Edward Norton, Meat Loaf",
                            Country = "Germany, United States",
                            Genre = "Drama",
                            Language = "English",
                            Plot = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNDIzNDU0YzEtYzE5Ni00ZjlkLTk5ZjgtNjM3NWE4YzA3Nzk3XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg",
                            Title = "Fight Club",
                            Year = 1999
                        },
                        new
                        {
                            Id = 12L,
                            Actors = "Elijah Wood, Ian McKellen, Orlando Bloom",
                            Country = "New Zealand, United States",
                            Genre = "Action, Adventure, Drama",
                            Language = "English, Sindarin",
                            Plot = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg",
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            Year = 2001
                        },
                        new
                        {
                            Id = 13L,
                            Actors = "Tom Hanks, Robin Wright, Gary Sinise",
                            Country = "United States",
                            Genre = "Drama, Romance",
                            Language = "English",
                            Plot = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                            Title = "Forrest Gump",
                            Year = 1994
                        },
                        new
                        {
                            Id = 14L,
                            Actors = "Mark Hamill, Harrison Ford, Carrie Fisher",
                            Country = "United States",
                            Genre = "Action, Adventure, Fantasy",
                            Language = "English",
                            Plot = "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued across the galaxy by Darth Vader and bounty hunter Boba Fett.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "Star Wars: Episode V - The Empire Strikes Back",
                            Year = 1980
                        },
                        new
                        {
                            Id = 15L,
                            Actors = "Leonardo DiCaprio, Joseph Gordon-Levitt, Elliot Page",
                            Country = "United States, United Kingdom",
                            Genre = "Action, Adventure, Sci-Fi",
                            Language = "English, Japanese, French",
                            Plot = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg",
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            Id = 16L,
                            Actors = "Elijah Wood, Ian McKellen, Viggo Mortensen",
                            Country = "New Zealand, United States",
                            Genre = "Action, Adventure, Drama",
                            Language = "English, Sindarin, Old English",
                            Plot = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                            Title = "The Lord of the Rings: The Two Towers",
                            Year = 2002
                        },
                        new
                        {
                            Id = 17L,
                            Actors = "Jack Nicholson, Louise Fletcher, Michael Berryman",
                            Country = "United States",
                            Genre = "Drama",
                            Language = "English",
                            Plot = "In the Fall of 1963, a Korean War veteran and criminal pleads insanity and is admitted to a mental institution, where he rallies up the scared patients against the tyrannical nurse.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BZjA0OWVhOTAtYWQxNi00YzNhLWI4ZjYtNjFjZTEyYjJlNDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                            Title = "One Flew Over the Cuckoo's Nest",
                            Year = 1975
                        },
                        new
                        {
                            Id = 18L,
                            Actors = "Robert De Niro, Ray Liotta, Joe Pesci",
                            Country = "United States",
                            Genre = "Biography, Crime, Drama",
                            Language = "English, Italian",
                            Plot = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                            Title = "Goodfellas",
                            Year = 1990
                        },
                        new
                        {
                            Id = 19L,
                            Actors = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                            Country = "United States, Australia",
                            Genre = "Action, Sci-Fi",
                            Language = "English",
                            Plot = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                            Title = "The Matrix",
                            Year = 1999
                        },
                        new
                        {
                            Id = 20L,
                            Actors = "Toshirô Mifune, Takashi Shimura, Keiko Tsushima",
                            Country = "Japan",
                            Genre = "Action, Drama",
                            Language = "Japanese",
                            Plot = "Farmers from a village exploited by bandits hire a veteran samurai for protection, who gathers six other samurai to join him.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNWQ3OTM4ZGItMWEwZi00MjI5LWI3YzgtNTYwNWRkNmIzMGI5XkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_SX300.jpg",
                            Title = "Seven Samurai",
                            Year = 1954
                        },
                        new
                        {
                            Id = 21L,
                            Actors = "Morgan Freeman, Brad Pitt, Kevin Spacey",
                            Country = "United States",
                            Genre = "Crime, Drama, Mystery",
                            Language = "English",
                            Plot = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BOTUwODM5MTctZjczMi00OTk4LTg3NWUtNmVhMTAzNTNjYjcyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                            Title = "Se7en",
                            Year = 1995
                        });
                });
#pragma warning restore 612, 618
        }
    }
}