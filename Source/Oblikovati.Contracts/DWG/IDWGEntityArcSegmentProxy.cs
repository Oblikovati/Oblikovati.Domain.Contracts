using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntityArcSegmentProxy
{
    object Geometry { get; }
    IDWGEntityArcSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}