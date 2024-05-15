using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Entities.Site;

public class Field : Entity
{
    public string Name { get; set; }
    public string UniqueName { get; set; }
    
    public Guid MapId { get; set; }
    public List<CropRow> CropRows { get; set; }

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

    public Field WithMap()
    {
        throw new NotImplementedException();
        MapId = new Guid();
        return this;
    }
}