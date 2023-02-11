using System.Linq.Expressions;
using System.Reflection;

namespace Domain.Grid;

public static class QueryableExtensions
{
    public static IQueryable<T> Filter<T>(this IQueryable<T> queryable, string property, object value)
    {
        return queryable.Filter(property, string.Empty, value);
    }

    public static IQueryable<T> Filter<T>(this IQueryable<T> queryable, string property, string comparison, object value)
    {
        if (string.IsNullOrWhiteSpace(property) || value == null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return queryable;
        }

        ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
        Expression expression = Create(property, parameterExpression);
        try
        {
            PropertyInfo property2 = typeof(T)!.GetProperty(property);
            if ((object)property2 == null)
            {
                return queryable;
            }

            Type type = Nullable.GetUnderlyingType(property2.PropertyType) ?? property2.PropertyType;
            value = Change(value, type);
        }
        catch
        {
            return Enumerable.Empty<T>().AsQueryable();
        }

        ConstantExpression right = Expression.Constant(value, expression.Type);
        Expression<Func<T, bool>> predicate = Expression.Lambda<Func<T, bool>>(Create(expression, comparison, right), new ParameterExpression[1] { parameterExpression });
        return queryable.Where(predicate);
    }

    public static IQueryable<T> Order<T>(this IQueryable<T> queryable, string property, bool ascending)
    {
        if (queryable == null || string.IsNullOrWhiteSpace(property))
        {
            return queryable;
        }

        ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
        dynamic val = Expression.Lambda(Create(property, parameterExpression), parameterExpression);
        return ascending ? Queryable.OrderBy(queryable, val) : Queryable.OrderByDescending(queryable, val);
    }

    public static IQueryable<T> Page<T>(this IQueryable<T> queryable, int index, int size)
    {
        if (queryable == null || index <= 0 || size <= 0)
        {
            return queryable;
        }

        return queryable.Skip((index - 1) * size).Take(size);
    }

    private static object Change(object value, Type type)
    {
        if (type.BaseType != typeof(Enum))
        {
            return Convert.ChangeType(value, type);
        }

        string text = value.ToString();
        if (text == null)
        {
            return null;
        }

        value = Enum.Parse(type, text);
        return Convert.ChangeType(value, type);
    }

    private static Expression Create(string property, Expression parameter)
    {
        return property.Split('.').Aggregate(parameter, new Func<Expression, string, Expression>(Expression.Property));
    }

    private static Expression Create(Expression left, string comparison, Expression right)
    {
        if (string.IsNullOrWhiteSpace(comparison) && left.Type == typeof(string))
        {
            return Expression.Call(left, "Contains", Type.EmptyTypes, right);
        }

        return Expression.MakeBinary(comparison switch
        {
            "<" => ExpressionType.LessThan,
            "<=" => ExpressionType.LessThanOrEqual,
            ">" => ExpressionType.GreaterThan,
            ">=" => ExpressionType.GreaterThanOrEqual,
            "!=" => ExpressionType.NotEqual,
            _ => ExpressionType.Equal,
        }, left, right);
    }
}
