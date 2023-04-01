using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPathEntityProxy
{
    IPath Parent { get; }
    object Curve { get; }
    CurveTypeEnum CurveType { get; }
    object SketchEntity { get; }
    bool OpposedToSketchEntity { get; }
    IPathEntity NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}