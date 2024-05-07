namespace MassTransit.Introduction;

public class CurrentTimeConsumer : IConsumer<CurrentTime>
{
    private readonly ILogger<CurrentTimeConsumer> _logger;

    public CurrentTimeConsumer(ILogger<CurrentTimeConsumer> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<CurrentTime> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(CurrentTimeConsumer), context.Message.Value);

        return Task.CompletedTask;
    }
}

public class CurrentTimeConsumerV2 : IConsumer<CurrentTime>
{
    private readonly ILogger<CurrentTimeConsumerV2> _logger;

    public CurrentTimeConsumerV2(ILogger<CurrentTimeConsumerV2> logger)
    {
        _logger = logger;
    }

    public Task Consume(ConsumeContext<CurrentTime> context)
    {
        _logger.LogInformation("{Consumer}: {Message}", nameof(CurrentTimeConsumerV2), context.Message.Value);

        return Task.CompletedTask;
    }
}