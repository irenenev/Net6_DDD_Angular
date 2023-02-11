using System.Security.Claims;

namespace Web.Sevices;

public interface IJwtService
{
    Dictionary<string, object> Decode(string token);

    string Encode(IList<Claim> claims);
}

