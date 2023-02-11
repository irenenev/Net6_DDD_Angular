using Database;
using Domain;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Web.Requests.Auth;
using Web.Responses.Auth;
using Web.Results;
using Web.Sevices;

namespace Web.Controllers;

[ApiController]
[Route("auths")]
public sealed class AuthController : ControllerBase
{
    private readonly IAuthRepository _authRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtService _jwtService;
    private IValidator<AuthRequest> _validator;
    public AuthController(
        IAuthRepository authRepository,
        IUnitOfWork unitOfWork,
        IJwtService jwtService,
        IValidator<AuthRequest> validator)
    {
        _authRepository = authRepository;
        _unitOfWork = unitOfWork;
        _jwtService = jwtService;
        _validator = validator;
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(AuthRequest request)
    {
        ValidationResult result = await _validator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result<AuthResponse>.Error(result.ToString()).ApiResult();
        }

        var errorLogin = Result<AuthResponse>.Error("Invalid login!").ApiResult();

        var errorPassword = Result<AuthResponse>.Error("Invalid password!").ApiResult();

        var auth = await _authRepository.GetByLoginAsync(request.Login);

        if (auth is null) return errorLogin;

        using DeriveBytes deriveBytes = new Rfc2898DeriveBytes(request.Password, Encoding.Default.GetBytes(auth.Salt.ToString()), 10000, HashAlgorithmName.SHA512);
        var password = Convert.ToBase64String(deriveBytes.GetBytes(512));

        if (auth.Password != password) return errorPassword;

        var claims = new List<Claim>
        {
            new Claim("sub", auth.Id.ToString())
        };

        var token = _jwtService.Encode(claims);

        var response = new AuthResponse(token);

        return Result<AuthResponse>.Success(response).ApiResult();
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register(AuthRequest request)
    {
        ValidationResult result = await _validator.ValidateAsync(request);

        if (!result.IsValid)
        {
            result.AddToModelState(ModelState);

            return Result<AuthResponse>.Error(result.ToString()).ApiResult();
        }

        if (await _authRepository.LoginExistsAsync(request.Login))
            return Result<AuthResponse>.Error("Login exists!").ApiResult();

        var auth = new Auth(request.Login, request.Password);

        using DeriveBytes deriveBytes = new Rfc2898DeriveBytes(request.Password, Encoding.Default.GetBytes(auth.Salt.ToString()), 10000, HashAlgorithmName.SHA512);
        var password = Convert.ToBase64String(deriveBytes.GetBytes(512));

        auth.UpdatePassword(password);

        await _authRepository.AddAsync(auth);

        await _unitOfWork.SaveChangesAsync();

        var claims = new List<Claim>
        {
            new Claim("sub", auth.Id.ToString())
        };

        var token = _jwtService.Encode(claims);

        var response = new AuthResponse(token);

        return Result<AuthResponse>.Success(response).ApiResult();
    }
}
