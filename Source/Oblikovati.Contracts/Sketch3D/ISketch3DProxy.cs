using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch3D.DimensionContraints3D;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;
using Oblikovati.Contracts.Sketch3D.HelicalCurves;
using Oblikovati.Contracts.Sketch3D.Profiles3D;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketch3DProxy
{
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IObjectsEnumerator Dependents { get; }
    IProfiles3D Profiles3D { get; }
    ISketchEntities3DEnumerator SketchEntities3D { get; }
    ISketchArcs3D SketchArcs3D { get; }
    ISketchLines3D SketchLines3D { get; }
    ISketchPoints3D SketchPoints3D { get; }
    ISketchCircles3D SketchCircles3D { get; }
    ISketchEllipses3D SketchEllipses3D { get; }
    ISketchEllipticalArcs3D SketchEllipticalArcs3D { get; }
    ISketchSplines3D SketchSplines3D { get; }
    ISketch3D ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Visible { get; set; }
    IGeometricConstraints3D GeometricConstraints3D { get; }
    bool Consumed { get; }
    IColor OverrideColor { get; set; }
    ISketchFixedSplines3D SketchFixedSplines3D { get; }
    ISilhouetteCurves SilhouetteCurves { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    bool DimensionsVisible { get; set; }
    bool Shared { get; set; }
    bool DeferUpdates { get; set; }
    IDimensionConstraints3D DimensionConstraints3D { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    IPartFeature OwnedBy { get; }
    bool Exported { get; set; }
    ISketchControlPointSplines3D SketchControlPointSplines3D { get; }
    ISketchEquationCurves3D SketchEquationCurves3D { get; }
    IIntersectionCurves IntersectionCurves { get; }
    IOnFaceCurves OnFaceCurves { get; }
    IHelicalCurves HelicalCurves { get; }
    int CheckSumValue { get; }
    IProjectToSurfaceCurves ProjectToSurfaceCurves { get; }
    ISketch3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void Edit();
    void ExitEdit();
    ISketchEntity3D Include(object Entity);
    ISketchEntity3D _CrossPartInclude(object Entity, IComponentOccurrence DestinationOccurrence);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void Solve();
}