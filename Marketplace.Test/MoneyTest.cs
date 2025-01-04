using Marketplace.Domain.ClassifiedAd;

namespace Marketplace.Test;

public class MoneyTest
{
    [Fact]
    public void Money_objects_with_the_same_amount_should_be_equal()
    {
        var firstAmount = new Money(5);
        var secondAmount = new Money(5);
        Assert.Equal(firstAmount, secondAmount);

    }
}