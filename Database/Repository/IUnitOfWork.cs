namespace Database;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
