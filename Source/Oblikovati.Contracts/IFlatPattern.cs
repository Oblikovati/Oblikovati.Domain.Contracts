using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.BOM;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;
using Oblikovati.Contracts.ModelAnnotations;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Sketch3D;

namespace Oblikovati.Contracts;

public interface IFlatPattern
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
    ISheetMetalComponentDefinition Parent { get; }
    ISurfaceBody Body { get; }
    IMassProperties MassProperties { get; }
    IFace TopFace { get; }
    IFace BottomFace { get; }
    IFace BaseFace { get; }
    PunchRepresentationTypeEnum PunchRepresentationType { get; set; }
    double Length { get; }
    double Width { get; }
    IFlatBendResults FlatBendResults { get; }
    IFlatPunchResults FlatPunchResults { get; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    BendAngleTypeEnum BendAngleReportType { get; set; }
    IFlatPatternFeatures Features { get; }
    IParameters Parameters { get; }
    IPartEvents PartEvents { get; }
    bool RolledBackForEdit { get; }
    IPlanarSketches Sketches { get; }
    ISketches3D Sketches3D { get; }
    IWorkAxes WorkAxes { get; }
    IWorkPlanes WorkPlanes { get; }
    IWorkPoints WorkPoints { get; }
    ISketchBlockDefinitions SketchBlockDefinitions { get; }
    IUserCoordinateSystems UserCoordinateSystems { get; }
    IRepresentationsManager RepresentationsManager { get; }
    IASideDefinition ASideFace { get; }
    IModelAnnotations ModelAnnotations { get; }
    IAnnotationPlanes AnnotationPlanes { get; }
    IFlatPatternOrientations FlatPatternOrientations { get; }
    bool IgnorePunchToolFeaturesRepresentationOverrides { get; set; }
    bool AreFacesMerged { get; }
    IFaces TopFaces { get; }
    IFaces BottomFaces { get; }
    IFlatPatternPlates Plates { get; }
    IModelToleranceFeatures ModelToleranceFeatures { get; }
    IClientGraphicsCollection _ClientGraphicsCollection { get; }
    bool UseOuterBendAngle { get; set; }
    IModelDatumReferenceFrames ModelDatumReferenceFrames { get; }

    IObjectsEnumerator FindUsingPoint(IPoint Point, List<SelectionFilterEnum> ObjectTypes, object ProximityTolerance,
        bool VisibleObjectsOnly);

    void _InvalidateSketchNodes();

    IObjectsEnumerator FindUsingVector(IPoint OriginPoint, IUnitVector Direction, List<SelectionFilterEnum> ObjectTypes,
        bool UseCylinder, object ProximityTolerance, bool VisibleObjectsOnly, out object LocationPoints);

    void Delete();
    IEdges GetEdgesOfType(FlatPatternEdgeTypeEnum EdgeType, bool TopFaceEdges);
    object GetFlatPatternEntity(object SheetMetalEntity);
    object GetSheetMetalEntity(object FlatPatternEntity);
    void Edit();
    void ExitEdit();

    void DeleteObjects(IObjectCollection Objects, bool RetainConsumedSketches, bool RetainDepFeatsAndSketches,
        bool RetainDepWorkFeats);

    void FindUsingRay(IPoint RayStartPoint, IUnitVector RayDirection, double Radius,
        out IObjectsEnumerator FoundEntities, out IObjectsEnumerator LocationPoints, bool FindFirstOnly);

    void GetEndOfPartPosition(out object After, out object Before);
    void SetEndOfPartToTopOrBottom(bool SetToTop);
    void SuppressFeatures(IObjectCollection Features);
    void UnsuppressFeatures(IObjectCollection Features);
    IGeometryIntent CreateGeometryIntent(object Geometry, object Intent);
    FlatPatternFaceTypeEnum GetFlatPatternFaceType(IFace Face);
    IFlatPatternPlate GetContainingPlateOfFace(IFace Face);
    void FlipBaseFace();
    void GetAlignment(out AlignmentTypeEnum AlignmentType, out object AlignedTo, out bool AlignmentDirectionReversed);
    void SetAlignment(AlignmentTypeEnum AlignmentType, object AlignedTo, bool AlignmentDirectionReversed);
    IView GetView(bool Create);
}