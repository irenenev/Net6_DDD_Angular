namespace Domain;

public class Film : Entity
{
    public Film
    (
        string title,
        int year,
        string genre,
        string poster,
        string actors = default(string),
        string plot = default(string),
        string lang = default(string),
        string country = default(string)
    )
    {
        Title = title;
        Year = year;
        Genre = genre;
        Poster = poster;
        Actors = actors;
        Plot = plot;
        Language = lang;
        Country = country;
    }

    public Film() { }

    public Film(long id) => Id = id;

    public string Title { get; }

    public int Year { get; }

    public string Genre { get; }

    public string Poster { get; }

    public string Actors { get; private set; }

    public string Plot { get; private set; }

    public string Language { get; private set; }

    public string Country { get; private set; }

    public void UpdateActors(string actors) => Actors = actors;

    public void UpdatePlot(string plot) => Plot = plot;

    public void UpdateLanguage(string lang) => Language = lang;

    public void UpdateCountry(string country) => Country = country;
}
