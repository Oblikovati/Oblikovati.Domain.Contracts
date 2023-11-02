using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.DWG;

public interface IDWGBlockReferenceProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGBlockDefinition Definition { get; }
    IMatrix Transformation { get; }
    IDWGBlockReference NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    object GetObject(object ObjectInDefinition);
}