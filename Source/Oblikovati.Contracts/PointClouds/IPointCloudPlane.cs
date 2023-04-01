using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudPlane
{
    IPointCloud Parent { get; }
    IPlane Geometry { get; }
    void GetPlaneRectangle(out IPlane Plane, out IUnitVector LengthDirection, out double Length, out double Height);
}