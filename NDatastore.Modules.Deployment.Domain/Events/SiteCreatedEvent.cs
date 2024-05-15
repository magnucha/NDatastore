using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Events;

public class SiteCreatedEvent : DomainEvent
{
    public readonly string Name;
    public readonly string UniqueName;

    public readonly Guid CustomerId;

    public SiteCreatedEvent(string name, string uniqueName, Guid customerId)
    {
        Name = name;
        UniqueName = uniqueName;
        CustomerId = customerId;
    }
}