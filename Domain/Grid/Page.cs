using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Grid;

public record Page
{
    protected virtual Type EqualityContract
    {
        get
        {
            return typeof(Page);
        }
    }

    public int Index { get; set; }

    public int Size { get; set; }

    public Page()
    {
        Index = 1;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Page");
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
        builder.Append("Index = ");
        builder.Append(Index.ToString());
        builder.Append(", Size = ");
        builder.Append(Size.ToString());
        return true;
    }

    public override int GetHashCode()
    {
        return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Index)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Size);
    }

    public virtual bool Equals(Page? other)
    {
        if ((object)this != other)
        {
            if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<int>.Default.Equals(Index, other!.Index))
            {
                return EqualityComparer<int>.Default.Equals(Size, other!.Size);
            }

            return false;
        }

        return true;
    }

    protected Page(Page original)
    {
        Index = original.Index;
        Size = original.Size;
    }
}
