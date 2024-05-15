using System.ComponentModel.DataAnnotations.Schema;
using NDatastore.Common.Domain;
using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Aggregates.Site;

public class Field : Entity
{
    public string Name { get; private set; }
    public string UniqueName { get; private set; }
    
    public List<CropRow> CropRows { get; private set; }

    protected Field()
    {
        CropRows = new List<CropRow>();
    }

    public Field(string name, string uniqueName) : this()
    {
        Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
        UniqueName = !string.IsNullOrWhiteSpace(uniqueName)
            ? uniqueName
            : throw new ArgumentNullException(nameof(uniqueName));
    }

    public bool IsEqualTo(string uniqueName)
    {
        return UniqueName == uniqueName;
    }
}