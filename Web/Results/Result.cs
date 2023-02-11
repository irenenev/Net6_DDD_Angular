using System.Runtime.CompilerServices;
using System.Text;

namespace Web.Results;

public record Result(ResultType Type, string Message)
{
    [CompilerGenerated]
    protected virtual Type EqualityContract
    {
        [CompilerGenerated]
        get
        {
            return typeof(Result);
        }
    }

    public bool HasMessage => !string.IsNullOrWhiteSpace(Message);

    public bool IsError => Type == ResultType.Error;

    public bool IsSuccess => Type == ResultType.Success;

    //public Result(ResultType Type, string Message)
    //{
    //    this.Type = ;
    //    this.Message = Message;
    //    base._002Ector();
    //}

    public static Result Error()
    {
        return new Result(ResultType.Error, null);
    }

    public static Result Error(string message)
    {
        return new Result(ResultType.Error, message);
    }

    public static Result Success()
    {
        return new Result(ResultType.Success, null);
    }

    public Result<T> Convert<T>()
    {
        return new Result<T>(Type, Message, default(T));
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
    protected virtual bool PrintMembers(StringBuilder builder)
    {
        RuntimeHelpers.EnsureSufficientExecutionStack();
        builder.Append("Type = ");
        builder.Append(Type.ToString());
        builder.Append(", Message = ");
        builder.Append((object?)Message);
        builder.Append(", HasMessage = ");
        builder.Append(HasMessage.ToString());
        builder.Append(", IsError = ");
        builder.Append(IsError.ToString());
        builder.Append(", IsSuccess = ");
        builder.Append(IsSuccess.ToString());
        return true;
    }

    [CompilerGenerated]
    public override int GetHashCode()
    {
        return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ResultType>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
    }

    [CompilerGenerated]
    public virtual bool Equals(Result? other)
    {
        if ((object)this != other)
        {
            if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<ResultType>.Default.Equals(Type, other!.Type))
            {
                return EqualityComparer<string>.Default.Equals(Message, other!.Message);
            }

            return false;
        }

        return true;
    }

    [CompilerGenerated]
    protected Result(Result original)
    {
        Type = original.Type;
        Message = original.Message;
    }
}
