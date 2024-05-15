using NDatastore.Common.Domain;
using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Aggregates.Customer;

public class Customer : Entity
{
    public string Name { get; set; }
    public string UniqueName { get; set; }
    
    public DateTimeOffset CustomerSince { get; set; }
}

