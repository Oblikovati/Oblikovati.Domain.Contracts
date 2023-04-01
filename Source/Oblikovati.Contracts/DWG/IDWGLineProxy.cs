using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.DWG;

public interface IDWGLineProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IUnitVector Direction { get; }
    IPoint EndPoint { get; }
    IPoint StartPoint { get; }
    IDWGLine NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}