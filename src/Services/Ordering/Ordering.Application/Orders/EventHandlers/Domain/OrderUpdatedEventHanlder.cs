namespace Ordering.Application.Orders.EventHandlers.Domain;

public class OrderUpdatedEventHanlder(ILogger<OrderUpdatedEventHanlder> logger)
    : INotificationHandler<OrderUpdatedEvent>
{
    public Task Handle(OrderUpdatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event Handled: { DomainEvent}", notification.GetType().Name);
        return Task.CompletedTask;
    }
}
