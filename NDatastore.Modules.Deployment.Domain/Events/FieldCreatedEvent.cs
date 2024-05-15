using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Events;

public class FieldCreatedEvent : DomainEvent
{
    public readonly string Name;
    public readonly string UniqueName;
    public readonly Guid MapId;
    public readonly Guid SiteId;

    public FieldCreatedEvent(string name, string uniqueName, Guid mapId, Guid siteId)
    {
        Name = name;
        UniqueName = uniqueName;
        MapId = mapId;
        SiteId = siteId;
    }
}