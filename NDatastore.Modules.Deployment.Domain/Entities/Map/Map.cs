using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Entities.Map;

public class Map : Entity
{
    public MapVersion Version { get; set; }
    public DateTimeOffset LastModified { get; set; }
}

