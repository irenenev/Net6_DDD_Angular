using Domain;

namespace Database;

public interface IAuthRepository : IRepository<Auth>
{
    Task<Auth> GetByLoginAsync(string login);

    Task<bool> LoginExistsAsync(string login);
}
