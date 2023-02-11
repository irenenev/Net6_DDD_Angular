using Domain;
using Microsoft.EntityFrameworkCore;

namespace Database;

public static class ContextSeed
{
    public static void Seed(this ModelBuilder builder)
    {
        builder.SeedUsers();
    }

    private static void SeedUsers(this ModelBuilder builder)
    {
        builder.Entity<Domain.Auth>(entity => entity.HasData(new
        {
            Id = 1L,
            Login = "admin@email.com",
            Password = "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK+u88gtSXAyPDkW+hVS+dW4AmxrnaNFZks0Zzcd5xlb12wcF/q96cc4htHFzvOH9jtN98N5EBIXSvdUVnFc9kBuRTVytATZA7gITbs//hkxvNQ3eody5U9hjdH6D+AP0vVt5unZlTZ+gInn8Ze7AC5o6mn0Y3ylGO1CBJSHU9c/BcFY9oknn+XYk9ySCoDGctMqDbvOBcvSTBkKcrCzev2KnX7xYmC3yNz1Q5oPVKgnq4mc1iuldMlCxse/IDGMJB2FRdTCLV5KNS4IZ1GB+dw3tMvcEEtmXmgT2zKN5+kUkOxhlv5g1ZLgXzWjVJeKb5uZpsn3WK5kt8T+kzMoxHd5i8HxsU2uvy9GopxAnaV0WNsBPqTGkRllSxARl4ZN3hJqUla553RT49tJxbs+N03OmkYhjq+L0aKJ1AC+7G+rdjegiAQZB+3mdE7a2Pne2kYtpMoCmNMKdm9jOOVpfXJqZMQul9ltJSlAY6LPrHFUB3mw61JBNzx+sZgYN29GfDY=",
            Salt = new Guid("79005744-e69a-4b09-996b-08fe0b70cbb9")
        }));

        builder.Entity<Film>(entity => entity.HasData(new
        {
            Id = 1L,
            Title = "Guardians of the Galaxy Vol. 2",
            Year = 2017,
            Genre = "Action, Adventure, Comedy",
            Poster = "https://m.media-amazon.com/images/M/MV5BNjM0NTc0NzItM2FlYS00YzEwLWE0YmUtNTA2ZWIzODc2OTgxXkEyXkFqcGdeQXVyNTgwNzIyNzg@._V1_SX300.jpg",
            Actors = "Chris Pratt, Zoe Saldana, Dave Bautista",
            Plot = "The Guardians struggle to keep together as a team while dealing with their personal family issues, notably Star-Lord's encounter with his father the ambitious celestial being Ego",
            Language = "English",
            Country = "United States"
        }, new
        {
            Id = 2L,
            Title = "The Shawshank Redemption",
            Year = 1994,
            Genre = "Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg",
            Actors = "Tim Robbins, Morgan Freeman, Bob Gunton",
            Plot = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
            Language = "English",
            Country = "United States"
        }, new
        {
            Id = 3L,
            Title = "The Godfather",
            Year = 1972,
            Genre = "Crime, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
            Actors = "Marlon Brando, Al Pacino, James Caan",
            Plot = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
            Language = "English, Italian, Latin",
            Country = "United States"
        }, new
        {
            Id = 4L,
            Title = "The Godfather: Part II",
            Year = 1974,
            Genre = "Crime, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
            Actors = "Al Pacino, Robert De Niro, Robert Duvall",
            Plot = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
            Language = "English, Italian, Spanish, Latin, Sicilian",
            Country = "United States"
        }, new
        {
            Id = 5L,
            Title = "The Dark Knight",
            Year = 2008,
            Genre = "Action, Crime, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SX300.jpg",
            Actors = "Christian Bale, Heath Ledger, Aaron Eckhart",
            Plot = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
            Language = "English, Mandarin",
            Country = "United States, United Kingdom"
        }, new
        {
            Id = 6L,
            Title = "12 Angry Men",
            Year = 1957,
            Genre = "Crime, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SX300.jpg",
            Actors = "Henry Fonda, Lee J. Cobb, Martin Balsam",
            Plot = "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.",
            Language = "English",
            Country = "United States"
        }, new
        {
            Id = 7L,
            Title = "Schindler's List",
            Year = 1993,
            Genre = "Biography, Drama, History",
            Poster = "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
            Actors = "Liam Neeson, Ralph Fiennes, Ben Kingsley",
            Plot = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
            Language = "English, Hebrew, German, Polish, Latin",
            Country = "United States"
        }, new
        {
            Id = 8L,
            Title = "The Lord of the Rings: The Return of the King",
            Year = 2003,
            Genre = "Action, Adventure, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
            Actors = "Elijah Wood, Viggo Mortensen, Ian McKellen",
            Plot = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
            Language = "English, Quenya, Old English, Sindarin",
            Country = "New Zealand, United States"
        }, new
        {
            Id = 9L,
            Title = "Pulp Fiction",
            Year = 1994,
            Genre = "Crime, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
            Actors = "John Travolta, Uma Thurman, Samuel L. Jackson",
            Plot = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
            Language = "English, Spanish, French",
            Country = "United States"
        }, new
        {
            Id = 10L,
            Title = "The Good, the Bad and the Ugly",
            Year = 1966,
            Genre = "Adventure, Western",
            Poster = "https://m.media-amazon.com/images/M/MV5BNjJlYmNkZGItM2NhYy00MjlmLTk5NmQtNjg1NmM2ODU4OTMwXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg",
            Actors = "Clint Eastwood, Eli Wallach, Lee Van Cleef",
            Plot = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
            Language = "Italian, English",
            Country = "Italy, Spain, West Germany"
        }, new
        {
            Id = 11L,
            Title = "Fight Club",
            Year = 1999,
            Genre = "Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BNDIzNDU0YzEtYzE5Ni00ZjlkLTk5ZjgtNjM3NWE4YzA3Nzk3XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg",
            Actors = "Brad Pitt, Edward Norton, Meat Loaf",
            Plot = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
            Language = "English",
            Country = "Germany, United States"
        }, new
        {
            Id = 12L,
            Title = "The Lord of the Rings: The Fellowship of the Ring",
            Year = 2001,
            Genre = "Action, Adventure, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg",
            Actors = "Elijah Wood, Ian McKellen, Orlando Bloom",
            Plot = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
            Language = "English, Sindarin",
            Country = "New Zealand, United States"
        }, new
        {
            Id = 13L,
            Title = "Forrest Gump",
            Year = 1994,
            Genre = "Drama, Romance",
            Poster = "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
            Actors = "Tom Hanks, Robin Wright, Gary Sinise",
            Plot = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood.",
            Language = "English",
            Country = "United States"
        }, new
        {
            Id = 14L,
            Title = "Star Wars: Episode V - The Empire Strikes Back",
            Year = 1980,
            Genre = "Action, Adventure, Fantasy",
            Poster = "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
            Actors = "Mark Hamill, Harrison Ford, Carrie Fisher",
            Plot = "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued across the galaxy by Darth Vader and bounty hunter Boba Fett.",
            Language = "English",
            Country = "United States"
        }, new
        {
            Id = 15L,
            Title = "Inception",
            Year = 2010,
            Genre = "Action, Adventure, Sci-Fi",
            Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg",
            Actors = "Leonardo DiCaprio, Joseph Gordon-Levitt, Elliot Page",
            Plot = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
            Language = "English, Japanese, French",
            Country = "United States, United Kingdom"
        }, new
        {
            Id = 16L,
            Title = "The Lord of the Rings: The Two Towers",
            Year = 2002,
            Genre = "Action, Adventure, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
            Actors = "Elijah Wood, Ian McKellen, Viggo Mortensen",
            Plot = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
            Language = "English, Sindarin, Old English",
            Country = "New Zealand, United States"
        }, new
        {
            Id = 17L,
            Title = "One Flew Over the Cuckoo's Nest",
            Year = 1975,
            Genre = "Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BZjA0OWVhOTAtYWQxNi00YzNhLWI4ZjYtNjFjZTEyYjJlNDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
            Actors = "Jack Nicholson, Louise Fletcher, Michael Berryman",
            Plot = "In the Fall of 1963, a Korean War veteran and criminal pleads insanity and is admitted to a mental institution, where he rallies up the scared patients against the tyrannical nurse.",
            Language = "English",
            Country = "United States"
        }, new
        {
            Id = 18L,
            Title = "Goodfellas",
            Year = 1990,
            Genre = "Biography, Crime, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
            Actors = "Robert De Niro, Ray Liotta, Joe Pesci",
            Plot = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
            Language = "English, Italian",
            Country = "United States"
        }, new
        {
            Id = 19L,
            Title = "The Matrix",
            Year = 1999,
            Genre = "Action, Sci-Fi",
            Poster = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
            Actors = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
            Plot = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
            Language = "English",
            Country = "United States, Australia"
        }, new
        {
            Id = 20L,
            Title = "Seven Samurai",
            Year = 1954,
            Genre = "Action, Drama",
            Poster = "https://m.media-amazon.com/images/M/MV5BNWQ3OTM4ZGItMWEwZi00MjI5LWI3YzgtNTYwNWRkNmIzMGI5XkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_SX300.jpg",
            Actors = "Toshirô Mifune, Takashi Shimura, Keiko Tsushima",
            Plot = "Farmers from a village exploited by bandits hire a veteran samurai for protection, who gathers six other samurai to join him.",
            Language = "Japanese",
            Country = "Japan"
        }, new
        {
            Id = 21L,
            Title = "Se7en",
            Year = 1995,
            Genre = "Crime, Drama, Mystery",
            Poster = "https://m.media-amazon.com/images/M/MV5BOTUwODM5MTctZjczMi00OTk4LTg3NWUtNmVhMTAzNTNjYjcyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
            Actors = "Morgan Freeman, Brad Pitt, Kevin Spacey",
            Plot = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
            Language = "English",
            Country = "United States"
        }));
    }
}
