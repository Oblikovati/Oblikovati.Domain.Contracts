using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISheetMetalComponentDefinition
{

    ISurfaceBodies SurfaceBodies { get; }
    IComponentOccurrences Occurrences { get; }
    object Document { get; }
    IDataIO DataIO { get; }
    IClientGraphicsCollection ClientGraphicsCollection { get; }
    string ModelGeometryVersion { get; }
    IAttributeSets AttributeSets { get; }
    BOMStructureEnum BOMStructure { get; set; }
    IBOMQuantity BOMQuantity { get; }
    IBox RangeBox { get; }
    IComponentDefinitionReferences ImmediateReferencedDefinitions { get; }
    IPartFeatures Features { get; }
    bool RolledBackForEdit { get; }
    IReferenceComponents ReferenceComponents { get; }
    IPlanarSketches Sketches { get; }
    ISketches3D Sketches3D { get; }
    IParameters Parameters { get; }
    IWorkAxes WorkAxes { get; }
    IWorkPlanes WorkPlanes { get; }
    IWorkPoints WorkPoints { get; }
    IWorkSurfaces WorkSurfaces { get; }
    IPartEvents PartEvents { get; }
    IMaterial Material { get; set; }
    IMassProperties MassProperties { get; }
    bool CompactModelHistoryOnNextSave { get; set; }
    IiPartFactory iPartFactory { get; }
    IiPartMember iPartMember { get; }
    bool IsiPartFactory { get; }
    bool IsiPartMember { get; }
    IiMateDefinitions iMateDefinitions { get; }
    IAnalysisManager AnalysisManager { get; }
    bool CompactModelHistory { get; set; }
    ISketchBlockDefinitions SketchBlockDefinitions { get; }
    IUserCoordinateSystems UserCoordinateSystems { get; }
    bool HasMultipleSolidBodies { get; }
    bool IsContentMember { get; }
    IRepresentationsManager RepresentationsManager { get; }
    IBIMComponent BIMComponent { get; }
    IObjectsEnumerator AppearanceOverridesObjects { get; }
    IModelAnnotations ModelAnnotations { get; }
    IAnnotationPlanes AnnotationPlanes { get; }
    IPointClouds PointClouds { get; }
    IMeshFeatureSets MeshFeatureSets { get; }
    IModelToleranceFeatures ModelToleranceFeatures { get; }
    IModelDatumReferenceFrames ModelDatumReferenceFrames { get; }
    IModelStates ModelStates { get; }
    bool IsModelStateFactory { get; }
    bool IsModelStateMember { get; }
    IDocument FactoryDocument { get; }
    ISheetMetalStyles SheetMetalStyles { get; }
    IUnfoldMethods UnfoldMethods { get; }
    ISheetMetalStyle ActiveSheetMetalStyle { get; }
    bool HasFlatPattern { get; }
    IFlatPattern FlatPattern { get; }
    IParameter Thickness { get; }
    IParameter BendRadius { get; }
    IParameter BendReliefDepth { get; }
    IParameter BendReliefWidth { get; }
    IParameter CornerReliefSize { get; }
    IParameter JacobiRadiusSize { get; }
    IParameter MinimumRemnant { get; }
    IParameter TransitionRadius { get; }
    IUnfoldMethod UnfoldMethod { get; set; }
    bool UseSheetMetalStyleMaterial { get; set; }
    bool UseSheetMetalStyleThickness { get; set; }
    bool UseSheetMetalStyleUnfoldMethod { get; set; }
    IBendsEnumerator Bends { get; }
    IParameter GapSize { get; }
    IASideDefinitions ASideDefinitions { get; }
    ASideFaceStatusEnum ASideFaceStatus { get; }
    IFace ASideFace { get; set; }
    IObjectsEnumerator FindUsingPoint(IPoint Point, List<SelectionFilterEnum> ObjectTypes, object ProximityTolerance, bool VisibleObjectsOnly);
    void _InvalidateSketchNodes();
    IObjectsEnumerator FindUsingVector(IPoint OriginPoint, IUnitVector Direction, List<SelectionFilterEnum> ObjectTypes, bool UseCylinder, object ProximityTolerance, bool VisibleObjectsOnly, out object LocationPoints);
    void _AutoStitchAndPromote();
    void FindUsingRay(IPoint RayStartPoint, IUnitVector RayDirection, double Radius, out IObjectsEnumerator FoundEntities, out IObjectsEnumerator LocationPoints, bool FindFirstOnly);
    IiPartFactory CreateFactory();
    void SetEndOfPartToTopOrBottom(bool SetToTop);
    void DeleteObjects(IObjectCollection Objects, bool RetainConsumedSketches, bool RetainDepFeatsAndSketches, bool RetainDepWorkFeats);
    void SuppressFeatures(IObjectCollection Features);
    void UnsuppressFeatures(IObjectCollection Features);
    void GetEndOfPartPosition(out object After, out object Before);
    void ExportObjects(IObjectCollection Objects);
    void ClearAppearanceOverrides(object AppearanceOverrideObjects);
    IGeometryIntent CreateGeometryIntent(object Geometry, object Intent);
    void Unfold();
    void Unfold2(IFace BaseFace);
    void UnfoldNoMerge(IFace BaseFace, bool ReplaceGeometry);
    ISheetMetalStyle GetBodySheetMetalStyle(ISurfaceBody Body);
    void SetBodySheetMetalStyle(ISurfaceBody Body, ISheetMetalStyle Value);
    void SetBodySheetMetalStyle2(ISurfaceBody Body, ISheetMetalStyle Value, bool AcceptErors);
}
