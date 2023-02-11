using FluentValidation;

namespace Web.Requests.Film;

public sealed class AddFilmRequestValidator : AbstractValidator<AddFilmRequest>
{
    public AddFilmRequestValidator()
    {
        RuleFor(request => request.Title).NotEmpty();
        RuleFor(request => request.Title).MaximumLength(100);
        RuleFor(request => request.Year).NotEmpty();
        RuleFor(request => request.Year.ToString()).Length(4);
        RuleFor(request => request.Poster).NotEmpty();
        RuleFor(request => request.Poster).MaximumLength(200);
        RuleFor(request => request.Genre).NotEmpty();
        RuleFor(request => request.Genre).MaximumLength(50);
        RuleFor(request => request.Plot).MaximumLength(1000);
        RuleFor(request => request.Actors).MaximumLength(200);
        RuleFor(request => request.Language).MaximumLength(50);
        RuleFor(request => request.Country).MaximumLength(50);
    }
}
