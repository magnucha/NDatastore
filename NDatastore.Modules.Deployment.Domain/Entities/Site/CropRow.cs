using NDatastore.Common.Domain.BaseClasses;

namespace Datastore.Modules.Deployment.Domain.Entities.Site;

public class CropRow : Entity
{
    public string Name;
    public double Length;
    public string CropType;
    public string Geometry;

    public CropRow(string name, double length, string cropType, string geometry)
    {
        Name = name;
        Length = length;
        CropType = cropType;
        Geometry = geometry;
    }
}


public class CropType
{
    public const string Strawberry = "strawberry";
    public const string WineGrape = "wine_grape";
}
