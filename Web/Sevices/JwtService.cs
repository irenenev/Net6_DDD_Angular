using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Web.Sevices
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Dictionary<string, object> Decode(string token)
        {
            return new JwtSecurityTokenHandler().ReadJwtToken(token).Payload;
        }

        public string Encode(IList<Claim> claims)
        {
            IConfigurationSection configurationSection = _configuration.GetSection("Authentication").GetChildren().First()
                .GetChildren()
                .First();
            SymmetricSecurityKey key = new SymmetricSecurityKey(Convert.FromBase64String(configurationSection.GetSection("SigningKeys").GetChildren().First()["Value"]));
            JwtSecurityToken token = new JwtSecurityToken(configurationSection["ValidIssuer"], configurationSection["ValidAudience"], claims ?? new List<Claim>(), DateTime.UtcNow, DateTime.UtcNow.Add(TimeSpan.FromDays(1.0)), new SigningCredentials(key, "HS256"));
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
