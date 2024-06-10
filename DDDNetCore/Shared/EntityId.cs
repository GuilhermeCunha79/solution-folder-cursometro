namespace WebApplication1.Shared;

public abstract class EntityId : IEquatable<EntityId>, IComparable<EntityId>
{
    protected object Value { get; }

    public string StringValue => Value.ToString();
    public int IntValue => Value is int intValue ? intValue : throw new InvalidOperationException("Value is not an integer.");
    
    public String ValueGuid
    {
        get
        {
            if (Value is string)
                return (String)Value;
            return AsString();
        }
    }
    
    protected EntityId(object value)
    {
        if (value is int || value is string)
            Value = value;
        else
            throw new ArgumentException("Value must be either an integer or a string.");
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        return obj is EntityId other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public bool Equals(EntityId other)
    {
        if (other == null)
            return false;
        if (GetType() != other.GetType())
            return false;
        return Value.Equals(other.Value);
    }

    public int CompareTo(EntityId other)
    {
        if (other == null)
            return -1;
        return String.Compare(StringValue, other.StringValue, StringComparison.Ordinal);
    }

    public static bool operator ==(EntityId obj1, EntityId obj2)
    {
        if (Equals(obj1, null))
        {
            if (Equals(obj2, null))
            {
                return true;
            }

            return false;
        }

        return obj1.Equals(obj2);
    }

    public static bool operator !=(EntityId x, EntityId y)
    {
        return !(x == y);
    }
    
    public abstract String AsString();
}
