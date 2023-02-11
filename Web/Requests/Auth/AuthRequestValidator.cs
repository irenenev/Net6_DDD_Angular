using FluentValidation;

namespace Web.Requests.Auth;

public sealed class AuthRequestValidator : AbstractValidator<AuthRequest>
{
    public AuthRequestValidator()
    {
        RuleFor(request => request.Login).NotEmpty().EmailAddress();
        RuleFor(request => request.Password).NotEmpty();
    }
}
