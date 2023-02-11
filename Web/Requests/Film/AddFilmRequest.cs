namespace Web.Requests.Film;

public sealed record AddFilmRequest
(
    string Title,
    int Year,
    string Genre,
    string Poster,
    string Actors,
    string Plot,
    string Language,
    string Country
);
