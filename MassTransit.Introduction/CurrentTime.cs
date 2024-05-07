namespace MassTransit.Introduction;

public record CurrentTime
{
    public string Value { get; init; } = string.Empty;
}