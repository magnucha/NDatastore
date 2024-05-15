using NDatastore.Common.Domain;
using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Aggregates.Map;

public class MapVersion(int majorVersion, int minorVersion) : ValueObject, IComparable<MapVersion>
{
    public int MajorVersion { get; init; } = majorVersion;
    public int MinorVersion { get; init; } = minorVersion;

    public int CompareTo(MapVersion? other)
    {
        if (MajorVersion != other?.MajorVersion)
        {
            return MajorVersion > other?.MajorVersion ? 1 : -1;
        }

        if (MinorVersion == other.MinorVersion)
        {
            return 0;
        }

        return MinorVersion > other.MinorVersion ? 1 : 0;
    }
    
    public static bool operator >(MapVersion obj1, MapVersion obj2)
    {
        return obj1.CompareTo(obj2) == 1;
    }

    public static bool operator <(MapVersion obj1, MapVersion obj2)
    {
        return obj1.CompareTo(obj2) == -1;
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return MajorVersion;
        yield return MinorVersion;
    }
}
