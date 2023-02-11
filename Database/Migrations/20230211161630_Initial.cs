using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Salt = table.Column<Guid>(type: "uniqueidentifier", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Actors = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Plot = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Auth",
                columns: new[] { "Id", "Login", "Password", "Salt" },
                values: new object[] { 1L, "admin@email.com", "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK+u88gtSXAyPDkW+hVS+dW4AmxrnaNFZks0Zzcd5xlb12wcF/q96cc4htHFzvOH9jtN98N5EBIXSvdUVnFc9kBuRTVytATZA7gITbs//hkxvNQ3eody5U9hjdH6D+AP0vVt5unZlTZ+gInn8Ze7AC5o6mn0Y3ylGO1CBJSHU9c/BcFY9oknn+XYk9ySCoDGctMqDbvOBcvSTBkKcrCzev2KnX7xYmC3yNz1Q5oPVKgnq4mc1iuldMlCxse/IDGMJB2FRdTCLV5KNS4IZ1GB+dw3tMvcEEtmXmgT2zKN5+kUkOxhlv5g1ZLgXzWjVJeKb5uZpsn3WK5kt8T+kzMoxHd5i8HxsU2uvy9GopxAnaV0WNsBPqTGkRllSxARl4ZN3hJqUla553RT49tJxbs+N03OmkYhjq+L0aKJ1AC+7G+rdjegiAQZB+3mdE7a2Pne2kYtpMoCmNMKdm9jOOVpfXJqZMQul9ltJSlAY6LPrHFUB3mw61JBNzx+sZgYN29GfDY=", new Guid("79005744-e69a-4b09-996b-08fe0b70cbb9") });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Language", "Plot", "Poster", "Title", "Year" },
                values: new object[,]
                {
                    { 1L, "Chris Pratt, Zoe Saldana, Dave Bautista", "United States", "Action, Adventure, Comedy", "English", "The Guardians struggle to keep together as a team while dealing with their personal family issues, notably Star-Lord's encounter with his father the ambitious celestial being Ego", "https://m.media-amazon.com/images/M/MV5BNjM0NTc0NzItM2FlYS00YzEwLWE0YmUtNTA2ZWIzODc2OTgxXkEyXkFqcGdeQXVyNTgwNzIyNzg@._V1_SX300.jpg", "Guardians of the Galaxy Vol. 2", 2017 },
                    { 2L, "Tim Robbins, Morgan Freeman, Bob Gunton", "United States", "Drama", "English", "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg", "The Shawshank Redemption", 1994 },
                    { 3L, "Marlon Brando, Al Pacino, James Caan", "United States", "Crime, Drama", "English, Italian, Latin", "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "The Godfather", 1972 },
                    { 4L, "Al Pacino, Robert De Niro, Robert Duvall", "United States", "Crime, Drama", "English, Italian, Spanish, Latin, Sicilian", "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.", "https://m.media-amazon.com/images/M/MV5BMWMwMGQzZTItY2JlNC00OWZiLWIyMDctNDk2ZDQ2YjRjMWQ0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "The Godfather: Part II", 1974 },
                    { 5L, "Christian Bale, Heath Ledger, Aaron Eckhart", "United States, United Kingdom", "Action, Crime, Drama", "English, Mandarin", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SX300.jpg", "The Dark Knight", 2008 },
                    { 6L, "Henry Fonda, Lee J. Cobb, Martin Balsam", "United States", "Crime, Drama", "English", "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict.", "https://m.media-amazon.com/images/M/MV5BMWU4N2FjNzYtNTVkNC00NzQ0LTg0MjAtYTJlMjFhNGUxZDFmXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SX300.jpg", "12 Angry Men", 1957 },
                    { 7L, "Liam Neeson, Ralph Fiennes, Ben Kingsley", "United States", "Biography, Drama, History", "English, Hebrew, German, Polish, Latin", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg", "Schindler's List", 1993 },
                    { 8L, "Elijah Wood, Viggo Mortensen, Ian McKellen", "New Zealand, United States", "Action, Adventure, Drama", "English, Quenya, Old English, Sindarin", "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "The Lord of the Rings: The Return of the King", 2003 },
                    { 9L, "John Travolta, Uma Thurman, Samuel L. Jackson", "United States", "Crime, Drama", "English, Spanish, French", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "Pulp Fiction", 1994 },
                    { 10L, "Clint Eastwood, Eli Wallach, Lee Van Cleef", "Italy, Spain, West Germany", "Adventure, Western", "Italian, English", "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.", "https://m.media-amazon.com/images/M/MV5BNjJlYmNkZGItM2NhYy00MjlmLTk5NmQtNjg1NmM2ODU4OTMwXkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg", "The Good, the Bad and the Ugly", 1966 },
                    { 11L, "Brad Pitt, Edward Norton, Meat Loaf", "Germany, United States", "Drama", "English", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "https://m.media-amazon.com/images/M/MV5BNDIzNDU0YzEtYzE5Ni00ZjlkLTk5ZjgtNjM3NWE4YzA3Nzk3XkEyXkFqcGdeQXVyMjUzOTY1NTc@._V1_SX300.jpg", "Fight Club", 1999 },
                    { 12L, "Elijah Wood, Ian McKellen, Orlando Bloom", "New Zealand, United States", "Action, Adventure, Drama", "English, Sindarin", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg", "The Lord of the Rings: The Fellowship of the Ring", 2001 },
                    { 13L, "Tom Hanks, Robin Wright, Gary Sinise", "United States", "Drama, Romance", "English", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood.", "https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "Forrest Gump", 1994 },
                    { 14L, "Mark Hamill, Harrison Ford, Carrie Fisher", "United States", "Action, Adventure, Fantasy", "English", "After the Rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued across the galaxy by Darth Vader and bounty hunter Boba Fett.", "https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "Star Wars: Episode V - The Empire Strikes Back", 1980 },
                    { 15L, "Leonardo DiCaprio, Joseph Gordon-Levitt, Elliot Page", "United States, United Kingdom", "Action, Adventure, Sci-Fi", "English, Japanese, French", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.", "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg", "Inception", 2010 },
                    { 16L, "Elijah Wood, Ian McKellen, Viggo Mortensen", "New Zealand, United States", "Action, Adventure, Drama", "English, Sindarin, Old English", "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.", "https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg", "The Lord of the Rings: The Two Towers", 2002 },
                    { 17L, "Jack Nicholson, Louise Fletcher, Michael Berryman", "United States", "Drama", "English", "In the Fall of 1963, a Korean War veteran and criminal pleads insanity and is admitted to a mental institution, where he rallies up the scared patients against the tyrannical nurse.", "https://m.media-amazon.com/images/M/MV5BZjA0OWVhOTAtYWQxNi00YzNhLWI4ZjYtNjFjZTEyYjJlNDVlL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg", "One Flew Over the Cuckoo's Nest", 1975 },
                    { 18L, "Robert De Niro, Ray Liotta, Joe Pesci", "United States", "Biography, Crime, Drama", "English, Italian", "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.", "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg", "Goodfellas", 1990 },
                    { 19L, "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss", "United States, Australia", "Action, Sci-Fi", "English", "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg", "The Matrix", 1999 },
                    { 20L, "Toshirô Mifune, Takashi Shimura, Keiko Tsushima", "Japan", "Action, Drama", "Japanese", "Farmers from a village exploited by bandits hire a veteran samurai for protection, who gathers six other samurai to join him.", "https://m.media-amazon.com/images/M/MV5BNWQ3OTM4ZGItMWEwZi00MjI5LWI3YzgtNTYwNWRkNmIzMGI5XkEyXkFqcGdeQXVyNDY2MTk1ODk@._V1_SX300.jpg", "Seven Samurai", 1954 },
                    { 21L, "Morgan Freeman, Brad Pitt, Kevin Spacey", "United States", "Crime, Drama, Mystery", "English", "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.", "https://m.media-amazon.com/images/M/MV5BOTUwODM5MTctZjczMi00OTk4LTg3NWUtNmVhMTAzNTNjYjcyXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg", "Se7en", 1995 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Login",
                table: "Auth",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Salt",
                table: "Auth",
                column: "Salt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Film_Title",
                table: "Film",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth");

            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
