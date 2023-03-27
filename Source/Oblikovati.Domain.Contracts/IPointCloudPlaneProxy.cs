namespace Oblikovati.Domain.Contracts;

public interface IPointCloudPlaneProxy
{

    IPointCloud Parent { get; }
    IPlane Geometry { get; }
    IPointCloudPlane NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetPlaneRectangle(out IPlane Plane, out IUnitVector LengthDirection, out double Length, out double Height);
}
