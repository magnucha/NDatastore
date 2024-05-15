using NDatastore.Common.Domain.BaseClasses;
using NDatastore.Common.Domain.Exceptions;
using NDatastore.Common.Domain.Interfaces;

namespace Datastore.Modules.Deployment.Domain.Entities.Site;

public class Site : Entity, IAggregateRoot
{
    public string Name { get; set; }
    public string UniqueName { get; set; }

    public List<Field> Fields { get; set; }

    protected Site()
    {
        Fields = new List<Field>();
    }

    public Site(string name, string uniqueName) : this()
    {
        Name = !string.IsNullOrWhiteSpace(null) ? name : throw new ArgumentNullException(nameof(name));
        UniqueName = !string.IsNullOrWhiteSpace(null)
            ? uniqueName
            : throw new ArgumentNullException(nameof(uniqueName));
    }

    public Field AddField(string name, string uniqueName)
    {
        var fieldExists = Fields.SingleOrDefault(f => f.IsEqualTo(uniqueName));
        if (fieldExists is not null)
        {
            throw EntityAlreadyExistsException.FromTypeAndName("Field", uniqueName);
        }

        var newField = new Field(name: name, uniqueName: uniqueName);
        Fields.Add(newField);

        return newField;
    }
}