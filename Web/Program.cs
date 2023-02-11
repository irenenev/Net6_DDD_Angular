using Database;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.OpenApi.Models;
using Web.Requests.Auth;
using Web.Requests.Film;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Web.Sevices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.SpaServices.AngularCli;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddResponseCompression();
//builder.Services.AddSwaggerGen(options =>
//{
//    options.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Version = "v1",
//        Title = "DDD API",
//        Description = "An ASP.NET Core Web API with DDD pattern"
//    });
//    options.AddSecurityDefinition("bearerAuth", new OpenApiSecurityScheme
//    {
//        Description = "JWT Authorization header using the Bearer scheme",
//        Name = "Authorization",
//        In = ParameterLocation.Header,
//        Type = SecuritySchemeType.Http,
//        Scheme = "bearer",
//        BearerFormat = "JWT"
//    });
//    options.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type = ReferenceType.SecurityScheme,
//                    Id = "bearerAuth"
//                }
//            },
//            new string[] {}
//        }
//    });
//});

builder.Services.AddSpaStaticFiles(opt => opt.RootPath = "Frontend/dist");
builder.Services.AddAuthentication(opt => opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(opt =>
{
        IConfigurationSection configurationSection = builder.Configuration
            .GetSection("Authentication").GetChildren().First()
                .GetChildren().First();
        opt.Audience = configurationSection["ValidAudience"];
        opt.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidAudience = configurationSection["ValidAudience"],
            ValidIssuer = configurationSection["ValidIssuer"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Convert.FromBase64String(configurationSection.GetSection("SigningKeys").GetChildren().First()["Value"]))
        };
    });
builder.Services.AddAuthorization();
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(Context))));
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
}).AddMvcOptions(options => options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build())));
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddScoped<IFilmRepository, FilmRepository>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
builder.Services.AddScoped<IValidator<AuthRequest>, AuthRequestValidator>();
builder.Services.AddScoped<IValidator<AddFilmRequest>, AddFilmRequestValidator>();
builder.Services.AddScoped<IValidator<GetFilmRequest>, GetFilmRequestValidator>();
builder.Services.AddScoped<IValidator<GridFilmRequest>, GridFilmRequestValidator>();
builder.Services.AddScoped<IValidator<UpdateFilmRequest>, UpdateFilmRequestValidator>();


var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<Context>();
    dataContext.Database.Migrate();
}
app.UseDeveloperExceptionPage();
app.UseHsts();
app.UseHttpsRedirection();
app.UseResponseCompression();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(options =>
//    {
//        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//        options.RoutePrefix = string.Empty;
//    });
//}
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints => endpoints.MapControllers());


app.UseSpaStaticFiles();
app.UseSpa(b =>
{
    b.Options.SourcePath = "Frontend";
    b.UseAngularCliServer(npmScript: "start");
});

app.Run();
