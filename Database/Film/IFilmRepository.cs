using Domain;
using Domain.Grid;

namespace Database;

public interface IFilmRepository : IRepository<Film>
{
    Task<bool> TitleExistsAsync(string title);

    Task<FilmModel> GetModelAsync(long id);

    Task<Grid<FilmModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<FilmModel>> ListModelAsync();
}
