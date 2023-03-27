namespace Oblikovati.Domain.Contracts;

public interface IPointCloudPlane
{

    IPointCloud Parent { get; }
    IPlane Geometry { get; }
    void GetPlaneRectangle(out IPlane Plane, out IUnitVector LengthDirection, out double Length, out double Height);
}
