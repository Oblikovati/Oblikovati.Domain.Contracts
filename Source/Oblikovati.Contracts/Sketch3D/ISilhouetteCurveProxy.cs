using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISilhouetteCurveProxy
{
    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    object DirectionEntity { get; set; }
    bool IncludeCoincidentSilhouettes { get; set; }
    ISketchEntities3DEnumerator SketchEntities { get; }
    object FacesOrBody { get; set; }
    ISurfaceBody Body { get; set; }
    IFaceCollection ExcludedFaces { get; set; }
    bool ExcludeStraightFaces { get; set; }
    bool ExcludeInternalFaces { get; set; }
    ISilhouetteCurve NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void BreakLink();
    void Delete();
    ISilhouetteCurve _Edit(object FacesOrBody, object DirectionEntity, bool IncludeCoincidentSilhouettes);

    ISilhouetteCurve Edit(ISurfaceBody FacesOrBody, object DirectionEntity, object ExcludedFaces,
        object ExcludeStraightFaces, object ExcludeInternalFaces);
}