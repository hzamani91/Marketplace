namespace Marketplace.Domain.ClassifiedAd;


public record struct ClassifiedAdId
{
    private readonly Guid _value;

    public ClassifiedAdId(Guid value)
    {
        if (value == default)
        {
            throw new ArgumentNullException(nameof(value),
            "Classified Ad is cannot be empty");
        }

        _value = value;
    }
}