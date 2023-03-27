using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWeldmentComponentDefinition
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
    I_AssemblyDocument Parent { get; }
    IAssemblyConstraints Constraints { get; }
    IParameters Parameters { get; }
    IAssemblyEvents AssemblyEvents { get; }
    IMassProperties MassProperties { get; }
    IOccurrencePatterns OccurrencePatterns { get; }
    IWorkAxes WorkAxes { get; }
    IWorkPlanes WorkPlanes { get; }
    IWorkPoints WorkPoints { get; }
    IiMateDefinitions iMateDefinitions { get; }
    IiMateResults iMateResults { get; }
    IComponentOccurrence ActiveOccurrence { get; }
    string Master { get; }
    string ActivePositionalState { get; set; }
    bool MasterActive { get; }
    IBOM BOM { get; }
    IFeatures Features { get; }
    IRepresentationsManager RepresentationsManager { get; }
    bool IsiAssemblyFactory { get; }
    bool IsiAssemblyMember { get; }
    IiAssemblyFactory iAssemblyFactory { get; }
    IiAssemblyMember iAssemblyMember { get; }
    IMaterial DefaultMaterial { get; set; }
    IPlanarSketches Sketches { get; }
    IUserCoordinateSystems UserCoordinateSystems { get; }
    IBIMComponent BIMComponent { get; }
    ISimulationManager SimulationManager { get; }
    IObjectsEnumerator AppearanceOverridesObjects { get; }
    IAsset DefaultVirtualComponentMaterial { get; set; }
    IAssemblyJoints Joints { get; }
    IModelAnnotations ModelAnnotations { get; }
    IPointClouds PointClouds { get; }
    IImportedComponents ImportedComponents { get; }
    IModelStates ModelStates { get; }
    bool IsModelStateFactory { get; }
    bool IsModelStateMember { get; }
    IDocument FactoryDocument { get; }
    IRevitExports RevitExports { get; }
    bool SubstituteUpdateModelGeometriesOnly { get; set; }
    IWelds Welds { get; }
    IMaterial Material { get; set; }
    IMachining Machining { get; }
    IPreparations Preparations { get; }
    IWeldsComponentDefinition WeldsComponentDefinition { get; }
    IAsset WeldEndFillAppearance { get; set; }
    AppearanceSourceTypeEnum WeldEndFillAppearanceSourceType { get; set; }
    IAsset WeldBeadMaterial { get; set; }
    IAsset WeldBeadAppearance { get; set; }
    AppearanceSourceTypeEnum WeldBeadAppearanceSourceType { get; set; }
    IObjectsEnumerator FindUsingPoint(IPoint Point, List<SelectionFilterEnum> ObjectTypes, object ProximityTolerance, bool VisibleObjectsOnly);
    void _InvalidateSketchNodes();
    IObjectsEnumerator FindUsingVector(IPoint OriginPoint, IUnitVector Direction, List<SelectionFilterEnum> ObjectTypes, bool UseCylinder, object ProximityTolerance, bool VisibleObjectsOnly, out object LocationPoints);
    void FindUsingRay(IPoint RayStartPoint, IUnitVector RayDirection, double Radius, out IObjectsEnumerator FoundEntities, out IObjectsEnumerator LocationPoints, bool FindFirstOnly);
    IInterferenceResults AnalyzeInterference(IObjectCollection Set1, object Set2);
    object AdjustProxyContext(object ObjectProxy);
    void GetPositionalStates(ref List<string> PositionalStates);
    IiAssemblyFactory CreateFactory();
    void TransformOccurrences(IObjectCollection Occurrences, IObjectCollection Transforms, bool IgnoreConstraints);
    IRigidBodyResults RigidBodyAnalysis(INameValueMap Options, object UniqueOccurrences, object UniqueOccurrenceSettings);
    void SuppressFeatures(IObjectCollection Features);
    void UnsuppressFeatures(IObjectCollection Features);
    void SetEndOfFeaturesToTopOrBottom(bool SetToTop);
    void GetEndOfFeaturesPosition(out object After, out object Before);
    void ExportObjects(IObjectCollection Objects);
    IVisibleOccurrenceFinder CreateVisibleOccurrenceFinder(bool Visible, double PercentageVisible, bool Compact);
    void DeleteObjects(IObjectCollection Objects);
    void ClearAppearanceOverrides(object AppearanceOverrideObjects);
    IGeometryIntent CreateGeometryIntent(object Geometry, object Intent);
    void HideAllRelationships();
    void SetOccurrencesProperty(IObjectCollection pOccurrences, string PropertyName, object Value);
    IRenderStyle GetEndFillRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetEndFillRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
}
