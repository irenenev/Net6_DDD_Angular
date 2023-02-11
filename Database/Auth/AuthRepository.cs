using Domain;

namespace Database;

public sealed class AuthRepository : Repository<Auth>, IAuthRepository
{
    public AuthRepository(Context context) : base(context) { }

    public Task<Auth> GetByLoginAsync(string login) => GetAsync(auth => auth.Login == login);

    public Task<bool> LoginExistsAsync(string login) => AnyAsync(auth => auth.Login == login);
}
