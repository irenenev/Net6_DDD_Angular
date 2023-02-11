using System.Runtime.CompilerServices;
using System.Text;

namespace Domain.Grid;

public record Order
{
    protected virtual Type EqualityContract
    {
        get
        {
            return typeof(Order);
        }
    }

    public bool Ascending { get; set; }

    public string? Property { get; set; }

    public Order()
    {
        Ascending = true;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Order");
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
        builder.Append("Ascending = ");
        builder.Append(Ascending.ToString());
        builder.Append(", Property = ");
        builder.Append((object?)Property);
        return true;
    }

    public override int GetHashCode()
    {
        return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Ascending)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Property);
    }

    public virtual bool Equals(Order? other)
    {
        if ((object)this != other)
        {
            if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<bool>.Default.Equals((Ascending ? ((byte)1) : ((byte)0)) != 0, (other!.Ascending ? ((byte)1) : ((byte)0)) != 0))
            {
                return EqualityComparer<string>.Default.Equals(Property, other!.Property);
            }

            return false;
        }

        return true;
    }

    protected Order(Order original)
    {
        Ascending = original.Ascending;
        Property = original.Property;
    }
}
