using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Web.Results;

public sealed record Result<T> : Result
{
    protected override Type EqualityContract
    {
        get
        {
            return typeof(Result<T>);
        }
    }

    public T Value { get; init; }

    public bool HasValue
    {
        get
        {
            if (Value != null)
            {
                return !object.Equals(Value, default(T));
            }

            return false;
        }
    }

    public Result(ResultType Type, string Message, T Value):base(Type, Message)
    {
        this.Value = Value;
        //base._002Ector(Type, Message);
    }

    public new static Result<T> Error(string message)
    {
        return new Result<T>(ResultType.Error, message, default(T));
    }

    public static Result<T> Success(T value)
    {
        return new Result<T>(ResultType.Success, null, value);
    }

    public new static Result<T> Success()
    {
        return new Result<T>(ResultType.Success, null, default(T));
    }

    [CompilerGenerated]
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Result");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(' ');
        }

        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }

    [CompilerGenerated]
    protected override bool PrintMembers(StringBuilder builder)
    {
        if (base.PrintMembers(builder))
        {
            builder.Append(", ");
        }

        builder.Append("Value = ");
        builder.Append(Value);
        builder.Append(", HasValue = ");
        builder.Append(HasValue.ToString());
        return true;
    }

    [CompilerGenerated]
    public override int GetHashCode()
    {
        return base.GetHashCode() * -1521134295 + EqualityComparer<T>.Default.GetHashCode(Value);
    }

    [CompilerGenerated]
    public bool Equals(Result<T>? other)
    {
        if ((object)this != other)
        {
            if (base.Equals(other))
            {
                return EqualityComparer<T>.Default.Equals(Value, other!.Value);
            }

            return false;
        }

        return true;
    }

    [CompilerGenerated]
    private Result(Result<T> original)
        : base(original)
    {
        Value = original.Value;
    }

    [CompilerGenerated]
    public void Deconstruct(out ResultType Type, out string Message, out T Value)
    {
        Type = base.Type;
        Message = base.Message;
        Value = this.Value;
    }
}
