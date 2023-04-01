using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntityLineSegmentProxy
{
    ILineSegment Geometry { get; }
    IDWGEntityLineSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}