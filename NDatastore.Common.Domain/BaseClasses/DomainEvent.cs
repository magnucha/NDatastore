using MediatR;

namespace NDatastore.Common.Domain.BaseClasses;

public class DomainEvent : INotification
{
    public Actor TriggeredBy { get; set; }
    public DateTimeOffset TriggeredAt { get; set; }
}

public record Actor(string Email);