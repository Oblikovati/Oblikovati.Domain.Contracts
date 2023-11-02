using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGPolylineProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitiesEnumerator Entities { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
    IDWGPolyline NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}