using System.Runtime.CompilerServices;
using System.Text;
using System.Linq.Expressions;

namespace Domain.Grid;

public record Grid<T>
{
    protected virtual Type EqualityContract
    {
        [CompilerGenerated]
        get
        {
            return typeof(Grid<T>);
        }
    }

    public long Count { get; }

    public IEnumerable<T> List { get; }

    public GridParameters Parameters { get; }

    public Grid(IQueryable<T> queryable, GridParameters parameters)
    {
        Parameters = parameters;
        if (queryable != null && (object)parameters != null)
        {
            queryable = Filter(queryable, parameters.Filters);
            Count = queryable.LongCount();
            queryable = Order(queryable, parameters.Order);
            queryable = Page(queryable, parameters.Page);
            List = queryable.AsEnumerable();
        }
    }

    private static IQueryable<T> Filter(IQueryable<T> queryable, Filters filters)
    {
        if (filters != null)
        {
            return filters.Aggregate(queryable, (IQueryable<T> current, Filter filter) => current.Filter(filter.Property, filter.Comparison, filter.Value));
        }

        return queryable;
    }

    private static IQueryable<T> Order(IQueryable<T> queryable, Order order)
    {
        if ((object)order != null)
        {
            if (queryable == null || string.IsNullOrWhiteSpace(order.Property))
            {
                return queryable;
            }

            ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
            dynamic val = Expression.Lambda(order.Property.Split('.').Aggregate(parameterExpression, new Func<Expression, string, Expression>(Expression.Property)), parameterExpression);
            return order.Ascending ? Queryable.OrderBy(queryable, val) : Queryable.OrderByDescending(queryable, val);
        }

        return queryable;
    }

    private static IQueryable<T> Page(IQueryable<T> queryable, Page page)
    {
        if ((object)page != null)
        {
            if (queryable == null || page.Index <= 0 || page.Size <= 0)
            {
                return queryable;
            }
            return queryable.Skip((page.Index - 1) * page.Size).Take(page.Size);
        }

        return queryable;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Grid");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(' ');
        }

        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }

    protected virtual bool PrintMembers(StringBuilder builder)
    {
        RuntimeHelpers.EnsureSufficientExecutionStack();
        builder.Append("Count = ");
        builder.Append(Count.ToString());
        builder.Append(", List = ");
        builder.Append(List);
        builder.Append(", Parameters = ");
        builder.Append(Parameters);
        return true;
    }

    public override int GetHashCode()
    {
        return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Count)) * -1521134295 + EqualityComparer<IEnumerable<T>>.Default.GetHashCode(List)) * -1521134295 + EqualityComparer<GridParameters>.Default.GetHashCode(Parameters);
    }

    public virtual bool Equals(Grid<T>? other)
    {
        if ((object)this != other)
        {
            if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<long>.Default.Equals(Count, other!.Count) && EqualityComparer<IEnumerable<T>>.Default.Equals(List, other!.List))
            {
                return EqualityComparer<GridParameters>.Default.Equals(Parameters, other!.Parameters);
            }

            return false;
        }

        return true;
    }

    protected Grid(Grid<T> original)
    {
        Count = original.Count;
        List = original.List;
        Parameters = original.Parameters;
    }
}
