using Database;
using Domain.Grid;
using Domain;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Requests.Film;
using Web.Results;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class FilmController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFilmRepository _filmRepository;
    private IValidator<AddFilmRequest> _addFilmValidator;
    private IValidator<GetFilmRequest> _getFilmValidator;
    private IValidator<GridFilmRequest> _gridFilmValidator;
    private IValidator<UpdateFilmRequest> _updateFilmValidator;

    public FilmController
    (
        IUnitOfWork unitOfWork,
        IFilmRepository filmRepository,
        IValidator<AddFilmRequest> addFilmValidator,
        IValidator<GetFilmRequest> getFilmValidator,
        IValidator<GridFilmRequest> gridFilmValidator,
        IValidator<UpdateFilmRequest> updateFilmValidator
    )
    {
        _unitOfWork = unitOfWork;
        _filmRepository = filmRepository;
        _addFilmValidator = addFilmValidator;
        _getFilmValidator = getFilmValidator;
        _gridFilmValidator = gridFilmValidator;
        _updateFilmValidator = updateFilmValidator;
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Add(AddFilmRequest request)
    {
        ValidationResult result = await _addFilmValidator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result<long>.Error(result.ToString()).ApiResult();
        }

        if (await _filmRepository.TitleExistsAsync(request.Title))
            return Result<long>.Error("Title exists!").ApiResult();

        var film = new Film
            (request.Title,
            request.Year,
            request.Genre,
            request.Poster,
            request.Actors,
            request.Plot,
            request.Language,
            request.Country);

        await _filmRepository.AddAsync(film);

        await _unitOfWork.SaveChangesAsync();

        return Result<long>.Success(film.Id).ApiResult();
    }

    [Authorize]
    [HttpDelete("{id:long}")]
    public async Task<IActionResult> Delete(long id)
    {
        var request = new GetFilmRequest(id);

        ValidationResult result = await _getFilmValidator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result.Error(result.ToString()).ApiResult();
        }

        var film = await _filmRepository.GetModelAsync(id);

        if (film is null) return Result.Error("Film is not found!").ApiResult();

        await _filmRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success().ApiResult();
    }

    [AllowAnonymous]
    [HttpGet("{id:long}")]
    public async Task<IActionResult> Get(long id)
    {
        var request = new GetFilmRequest(id);

        ValidationResult result = await _getFilmValidator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result<Film>.Error(result.ToString()).ApiResult();
        }

        var film = await _filmRepository.GetAsync(request.Id);

        if (film is null) return Result<Film>.Error("Film is not found!").ApiResult();

        return Result<Film>.Success(film).ApiResult();
    }

    [AllowAnonymous]
    [HttpGet("grid")]
    public async Task<IActionResult> Grid([FromQuery] GridFilmRequest request)
    {
        ValidationResult result = await _gridFilmValidator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result<Grid<FilmModel>>.Error(result.ToString()).ApiResult();
        }

        var grid = await _filmRepository.GridAsync(request);

        return Result<Grid<FilmModel>>.Success(grid).ApiResult();
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var films = await _filmRepository.ListModelAsync();

        return Result<IEnumerable<FilmModel>>.Success(films).ApiResult();
    }

    [Authorize]
    [HttpPut("{id:long}")]
    public async Task<IActionResult> Update(UpdateFilmRequest request)
    {
        ValidationResult result = await _updateFilmValidator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result.Error(result.ToString()).ApiResult();
        }

        var film = await _filmRepository.GetAsync(request.Id);

        if (film is null) return Result.Error("Film is not found!").ApiResult();

        if (!string.IsNullOrEmpty(request.Plot) && !string.IsNullOrWhiteSpace(request.Plot))
            film.UpdatePlot(request.Plot);

        if (!string.IsNullOrEmpty(request.Actors) && !string.IsNullOrWhiteSpace(request.Actors))
            film.UpdateActors(request.Actors);

        if (!string.IsNullOrEmpty(request.Language) && !string.IsNullOrWhiteSpace(request.Language))
            film.UpdateLanguage(request.Language);

        if (!string.IsNullOrEmpty(request.Country) && !string.IsNullOrWhiteSpace(request.Country))
            film.UpdateCountry(request.Country);

        await _filmRepository.UpdateAsync(film);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success().ApiResult();
    }
}
