namespace Domain;

public sealed record FilmModel
{
    public long Id { get; init; }

    public string Title { get; init; }

    public int Year { get; init; }

    public string Poster { get; init; }

    public string Genre { get; init; }
}
