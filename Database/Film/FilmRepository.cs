using Domain.Grid;
using Domain;
using System.Linq.Expressions;

namespace Database;

public sealed class FilmRepository : Repository<Film>, IFilmRepository
{
    public FilmRepository(Context context) : base(context) { }

    public static Expression<Func<Film, FilmModel>> Model => film => new FilmModel
    {
        Id = film.Id,
        Title = film.Title,
        Year = film.Year,
        Genre = film.Genre,
        Poster = film.Poster
    };

    public Task<bool> TitleExistsAsync(string title) => AnyAsync(film => film.Title == title);

    public Task<FilmModel> GetModelAsync(long id) =>
        Task.FromResult(Queryable.Where(film => film.Id == id).Select(Model).FirstOrDefault());


    public Task<Grid<FilmModel>> GridAsync(GridParameters parameters) => 
        Task.FromResult(new Grid<FilmModel>(Queryable.Select(Model), parameters));

    public async Task<IEnumerable<FilmModel>>ListModelAsync() => Queryable.Select(Model).AsEnumerable();
}
