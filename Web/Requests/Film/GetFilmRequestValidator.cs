using FluentValidation;

namespace Web.Requests.Film;

public sealed class GetFilmRequestValidator : AbstractValidator<GetFilmRequest>
{
    public GetFilmRequestValidator()
    {
        RuleFor(request => request.Id).GreaterThan(0);
    }
}
