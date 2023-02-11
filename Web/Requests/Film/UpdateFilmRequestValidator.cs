using FluentValidation;

namespace Web.Requests.Film;

public sealed class UpdateFilmRequestValidator : AbstractValidator<UpdateFilmRequest>
{
    public UpdateFilmRequestValidator()
    {
        RuleFor(request => request.Id).NotEmpty().GreaterThan(0);
        RuleFor(request => request.Plot).MaximumLength(1000);
        RuleFor(request => request.Actors).MaximumLength(200);
        RuleFor(request => request.Language).MaximumLength(50);
        RuleFor(request => request.Country).MaximumLength(50);
    }
}
