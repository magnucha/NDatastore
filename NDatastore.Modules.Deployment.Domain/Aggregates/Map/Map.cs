using NDatastore.Common.Domain;
using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Aggregates.Map;

public class Map : Entity
{
    public MapVersion Version { get; set; }
    public DateTimeOffset LastModified { get; set; }
}

