namespace Domain;

public sealed class Auth : Entity
{
    public Auth
    (
        string login,
        string password
    )
    {
        Login = login;
        Password = password;
        Salt = Guid.NewGuid();
    }

    public string Login { get; }

    public string Password { get; private set; }

    public Guid Salt { get; }

    public void UpdatePassword(string password) => Password = password;
}
