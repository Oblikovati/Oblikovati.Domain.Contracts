using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGPointProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Point { get; }
    IDWGPoint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}