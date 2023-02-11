using FluentValidation;

namespace Web.Requests.Film;

public sealed class GridFilmRequestValidator : AbstractValidator<GridFilmRequest>
{
    public GridFilmRequestValidator()
    {
        When(request => request.Page != null, () =>
        {
            RuleFor(request => request.Page.Index).GreaterThanOrEqualTo(0);
            RuleFor(request => request.Page.Size).GreaterThanOrEqualTo(0);
        });
    }
}
