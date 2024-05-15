using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Entities.Customer;

public class Customer : Entity
{
    public string Name { get; set; }
    public string UniqueName { get; set; }
    
    public DateTimeOffset CustomerSince { get; set; }

    public List<Guid> SiteIds { get; set; } = [];

    public Customer(string name, string uniqueName)
    {
        Name = name;
        UniqueName = uniqueName;
        CustomerSince = DateTimeOffset.UtcNow;
    }

    public Customer WithSites()
    {
        throw new NotImplementedException();

        SiteIds = new List<Guid>();
        return this;
    }
}
