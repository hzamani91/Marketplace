namespace Marketplace.Domain.ClassifiedAd;

public class ClassifiedAd
{
    public ClassifiedAd(ClassifiedAdId id, UserId ownerId)
    {
        if (id == default)
            throw new ArgumentNullException("Identity must be specified", nameof(id));

        Id = id;
        _ownerId = ownerId;

    }

    public void SetTitle(string title) => _title = title;
    public void UpdateText(string text) => _text = text;
    public void UpdatePrice(Price price) => _price = price;

    public ClassifiedAdId Id { get; private set; }
    private UserId _ownerId;
    private string _title;
    private string _text;
    private Price _price;
}