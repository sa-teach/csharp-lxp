using System.Globalization;

namespace CP4_Balance;

public class Balance
{
    public decimal Amount { get; }

    public Balance(decimal amount)
    {
        Amount = amount;
    }

    public static bool operator ==(Balance? left, Balance? right)
    {
        if (ReferenceEquals(left, right))
            return true;

        if (left is null || right is null)
            return false;

        return left.Amount == right.Amount;
    }

    public static bool operator !=(Balance? left, Balance? right)
    {
        return !(left == right);
    }

    public override bool Equals(object? obj)
    {
        return obj is Balance other && this == other;
    }

    public override int GetHashCode()
    {
        return Amount.GetHashCode();
    }

    public static bool operator <(Balance left, Balance right)
    {
        return left.Amount < right.Amount;
    }

    public static bool operator >(Balance left, Balance right)
    {
        return left.Amount > right.Amount;
    }

    public static bool operator <=(Balance left, Balance right)
    {
        return left.Amount <= right.Amount;
    }

    public static bool operator >=(Balance left, Balance right)
    {
        return left.Amount >= right.Amount;
    }

    public static bool operator true(Balance balance)
    {
        return balance.Amount > 0;
    }

    public static bool operator false(Balance balance)
    {
        return balance.Amount <= 0;
    }

    public override string ToString()
    {
        return $"{Amount.ToString("0.00", CultureInfo.GetCultureInfo("ru-RU"))} руб.";
    }
}
