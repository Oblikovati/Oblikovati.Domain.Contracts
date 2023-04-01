using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntitySplineSegmentProxy
{
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
    IDWGEntitySplineSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}