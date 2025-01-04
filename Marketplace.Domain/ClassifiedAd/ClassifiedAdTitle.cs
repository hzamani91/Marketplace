
public record struct ClassifiedAdTitle
{
    public static ClassifiedAdTitle Fromstring(string title) => new ClassifiedAdTitle(title);
    private readonly string _value;

    private ClassifiedAdTitle(string value)
    {
        if (value.Length > 100)
        {
            throw new ArgumentOutOfRangeException(
                "Title cannot be longer that 100 characters",
                nameof(value)
            );
        }

        _value = value;
    }
}