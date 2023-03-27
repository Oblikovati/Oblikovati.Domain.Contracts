namespace Oblikovati.Domain.Contracts;

public interface IPointCloudCrop
{

    IOrientedBox BoundingBox { get; }
    bool KeepInside { get; }
    IPointCloud Parent { get; }
}
