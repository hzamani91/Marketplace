namespace Marketplace.Domain;

public class ClassifiedAd
{
    public ClassifiedAd(Guid id)
    {
        if (id == default)
        {
            throw new ArgumentNullException("Identity must be specified", nameof(id));
            Id = id;
        }
    }
    public Guid Id { get; private set; }
    private Guid _ownerId;
    private string _title;
    private string _text;
    private decimal _price;
}