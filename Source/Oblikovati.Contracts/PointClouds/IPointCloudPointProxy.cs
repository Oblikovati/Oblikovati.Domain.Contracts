using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.PointClouds;

public interface IPointCloudPointProxy
{
    IPointCloud Parent { get; }
    IPoint Geometry { get; }
    IPointCloudPoint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}