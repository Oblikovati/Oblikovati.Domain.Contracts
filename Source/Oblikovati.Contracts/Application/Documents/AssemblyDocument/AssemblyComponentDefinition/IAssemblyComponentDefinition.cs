using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.BIMExchange;
using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.ModelAnnotations;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.PointClouds;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

public interface IAssemblyComponentDefinition
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
    IAssemblyDocument Parent { get; }
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

    IObjectsEnumerator FindUsingPoint(IPoint Point, List<SelectionFilterEnum> ObjectTypes, object ProximityTolerance,
        bool VisibleObjectsOnly);

    void _InvalidateSketchNodes();

    IObjectsEnumerator FindUsingVector(IPoint OriginPoint, IUnitVector Direction, List<SelectionFilterEnum> ObjectTypes,
        bool UseCylinder, object ProximityTolerance, bool VisibleObjectsOnly, out object LocationPoints);

    void FindUsingRay(IPoint RayStartPoint, IUnitVector RayDirection, double Radius,
        out IObjectsEnumerator FoundEntities, out IObjectsEnumerator LocationPoints, bool FindFirstOnly);

    IInterferenceResults AnalyzeInterference(IObjectCollection Set1, object Set2);
    object AdjustProxyContext(object ObjectProxy);
    void GetPositionalStates(ref List<string> PositionalStates);
    IiAssemblyFactory CreateFactory();
    void TransformOccurrences(IObjectCollection Occurrences, IObjectCollection Transforms, bool IgnoreConstraints);

    IRigidBodyResults RigidBodyAnalysis(INameValueMap Options, object UniqueOccurrences,
        object UniqueOccurrenceSettings);

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
}