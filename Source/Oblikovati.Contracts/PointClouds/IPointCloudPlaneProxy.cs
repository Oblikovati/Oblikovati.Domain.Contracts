using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudPlaneProxy
{
    IPointCloud Parent { get; }
    IPlane Geometry { get; }
    IPointCloudPlane NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetPlaneRectangle(out IPlane Plane, out IUnitVector LengthDirection, out double Length, out double Height);
}