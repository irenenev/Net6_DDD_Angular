using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;

namespace Database;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _context;
    
    public DbSet<T> TrackingSet 
    {
        get
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
            _context.ChangeTracker.LazyLoadingEnabled = true;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            return _context.Set<T>();
        }
    }

    public DbSet<T> NoTrackingSet
    {
        get
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
            _context.ChangeTracker.LazyLoadingEnabled = false;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return _context.Set<T>();
        }
    }

    public IQueryable<T> Queryable => NoTrackingSet.AsNoTracking();

    public Repository(DbContext context)
    {
        _context = context;
    }

    public Task AddAsync(T item)
    {
        return TrackingSet.AddAsync(item).AsTask();
    }

    public Task DeleteAsync(object key)
    {
        return Task.Run(delegate
        {
            T val = TrackingSet.Find(key);
            if (val != null) TrackingSet.Remove(val);
        });
    }

    public Task UpdateAsync(T item)
    {
        return Task.Run(delegate
        {
            object[] keyValues = _context.Model
            .FindEntityType(typeof(T))?
            .FindPrimaryKey()?.Properties
            .Select((IProperty property) =>
            item.GetType().GetProperty(property.Name)?.GetValue(item, null)).ToArray();
            T val = TrackingSet.Find(keyValues);
            if (val != null)
            {
                _context.Entry(val).State = EntityState.Detached;
                _context.Update(item);
            }
        });
    }

    public Task<bool> AnyAsync(Expression<Func<T, bool>> where)
    {
        return Queryable.AnyAsync(where);
    }

    public Task<T> GetAsync(Expression<Func<T, bool>> where)
    {
        return Queryable.FirstOrDefaultAsync(where);
    }

    public Task<T> GetAsync(object key)
    {
        return NoTrackingSet.FindAsync(key).AsTask();
    }
}
