namespace Domain;

public abstract class Entity
{
    public long Id { get; init; }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }

    public static bool operator ==(Entity left, Entity right)
    {
        return left?.Equals(right) ?? false;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Entity))
        {
            return false;
        }

        if (this == obj)
        {
            return true;
        }

        return ((Entity)obj).Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
