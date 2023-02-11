using System.Runtime.CompilerServices;
using System.Text;

namespace Domain.Grid;

public record GridParameters
{
    protected virtual Type EqualityContract
    {
        get
        {
            return typeof(GridParameters);
        }
    }

    public Filters Filters { get; set; }

    public Order Order { get; set; }

    public Page Page { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("GridParameters");
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
        builder.Append("Filters = ");
        builder.Append(Filters);
        builder.Append(", Order = ");
        builder.Append(Order);
        builder.Append(", Page = ");
        builder.Append(Page);
        return true;
    }

    public override int GetHashCode()
    {
        return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Filters>.Default.GetHashCode(Filters)) * -1521134295 + EqualityComparer<Order>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<Page>.Default.GetHashCode(Page);
    }

    public virtual bool Equals(GridParameters? other)
    {
        if ((object)this != other)
        {
            if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Filters>.Default.Equals(Filters, other!.Filters) && EqualityComparer<Order>.Default.Equals(Order, other!.Order))
            {
                return EqualityComparer<Page>.Default.Equals(Page, other!.Page);
            }

            return false;
        }

        return true;
    }

    protected GridParameters(GridParameters original)
    {
        Filters = original.Filters;
        Order = original.Order;
        Page = original.Page;
    }

    public GridParameters()
    {
        Filters = new Filters();
        Page= new Page();
        Order= new Order();
    }
}
