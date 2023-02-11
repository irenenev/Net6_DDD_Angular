using System.Linq.Expressions;

namespace Database;

public interface IRepository<T> where T : class
{
    IQueryable<T> Queryable { get; }

    Task<bool> AnyAsync(Expression<Func<T, bool>> where);

    Task AddAsync(T item);

    Task<T> GetAsync(Expression<Func<T, bool>> where);

    Task<T> GetAsync(object ket);

    Task UpdateAsync(T item);

    Task DeleteAsync(object key);
}
