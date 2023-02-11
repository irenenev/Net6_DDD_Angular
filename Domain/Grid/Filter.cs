using System.Runtime.CompilerServices;
using System.Text;

namespace Domain.Grid;

public record Filter
{
    protected virtual Type EqualityContract
    {
        get
        {
            return typeof(Filter);
        }
    }

    public string? Property { get; set; }

    public string? Comparison { get; set; }

    public string? Value { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Filter");
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
        builder.Append("Property = ");
        builder.Append((object?)Property);
        builder.Append(", Comparison = ");
        builder.Append((object?)Comparison);
        builder.Append(", Value = ");
        builder.Append((object?)Value);
        return true;
    }

    public override int GetHashCode()
    {
        return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Property)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Comparison)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
    }

    public virtual bool Equals(Filter? other)
    {
        if ((object)this != other)
        {
            if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Property, other!.Property) && EqualityComparer<string>.Default.Equals(Comparison, other!.Comparison))
            {
                return EqualityComparer<string>.Default.Equals(Value, other!.Value);
            }

            return false;
        }

        return true;
    }

    protected Filter(Filter original)
    {
        Property = original.Property;
        Comparison = original.Comparison;
        Value = original.Value;
    }

    public Filter()
    {
        //Property = string.Empty;
        //Comparison = string.Empty;
        //Value = string.Empty;
    }
}
