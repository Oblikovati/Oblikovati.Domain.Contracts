using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

namespace Oblikovati.Contracts.DWG;

public interface IDWGEntitySegmentProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitySegment NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}