namespace Web.Requests.Film;

public sealed record UpdateFilmRequest(long Id, string Plot, string Actors, string Language, string Country);
