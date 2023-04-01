using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntityEllipticalArcSegmentProxy
{
    object Geometry { get; }
    IDWGEntityEllipticalArcSegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}