namespace Marketplace.Domain;

public record struct Price
{
    public Price(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Price cannot be negative", nameof(amount));
    }
}
