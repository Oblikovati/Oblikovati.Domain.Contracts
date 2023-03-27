namespace Oblikovati.Domain.Contracts;

public interface IPointCloudPoint
{

    IPointCloud Parent { get; }
    IPoint Geometry { get; }
}
