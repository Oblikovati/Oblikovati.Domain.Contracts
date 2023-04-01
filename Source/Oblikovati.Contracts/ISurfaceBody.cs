using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts;

public interface ISurfaceBody
{
    IFaceShells FaceShells { get; }
    IFaces Faces { get; }
    IEdges Edges { get; }
    IVertices Vertices { get; }
    IWires Wires { get; }
    IComponentDefinition ComponentDefinition { get; }
    IBox RangeBox { get; }
    IBox PreciseRangeBox { get; }
    bool IsSolid { get; }
    double Volume { get; }
    int GeometryForm { get; }
    ISurfaceBody AlternateBody { get; }
    IAttributeSets AttributeSets { get; }
    IEdgeCollection ConcaveEdges { get; }
    IEdgeCollection ConvexEdges { get; }
    bool Visible { get; set; }
    ContainmentEnum IsPointInside { get; }
    IDataIO DataIO { get; }
    bool IsTransient { get; }
    IPartFeature CreatedByFeature { get; }
    IPartFeaturesEnumerator AffectedByFeatures { get; }
    string Name { get; set; }
    bool Exported { get; set; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    IOrientedBox OrientedMinimumRangeBox { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    void CalculateFacets(double Tolerance, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates,
        out List<double> NormalVectors, out List<int> VertexIndices);

    void GetExistingFacets(double ToleranceIndex, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices);

    void GetExistingFacetTolerances(out int ToleranceCount, out List<double> ExistingTolerances);

    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount,
        out List<double> VertexCoordinates, out List<int> VertexIndices);

    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out List<double> VertexCoordinates,
        out int PolylineCount, out List<int> PolylineLengths);

    void GetExistingStrokeTolerances(out int ToleranceCount, out List<double> ExistingTolerances);
    object LocateUsingPoint(ObjectTypeEnum ObjectType, IPoint PointOn, object ProximityTolerance);

    void FindUsingRay(IPoint RayStartPoint, IUnitVector RayDirection, double Radius,
        out IObjectsEnumerator FoundEntities, out IObjectsEnumerator LocationPoints, bool FindFirstOnly);

    object BindTransientKeyToObject(int TransientKey);

    void CalculateFacetsAndTextureMap(double Tolerance, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices,
        out List<double> TextureCoordinates);

    void GetExistingFacetsAndTextureMap(double ToleranceIndex, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices,
        out List<double> TextureCoordinates);

    void CalculateFacetsWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount,
        out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors,
        out List<int> VertexIndices, out object TextureCoordinates);

    void GetExistingFacetsAndTextureMap2(double ChordalTolerance, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices,
        out List<double> TextureCoordinates, out List<int> IndexCountPerFace);

    void CalculateStrokesWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount,
        out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);

    void Delete();
    bool IsEntityValid(object EntityToCheck, int CheckLevel, ref object ProblemEntities);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle, bool StripOverrides);
    INameValueMap GetASMAttributes(object Entity);
    void ClearAppearanceOverrides();

    void GetAppearanceTextureMappingData(out TextureMappingTypeEnum TextureMappingType,
        out object TextureMappingAlignment);

    void SetAppearanceTextureMappingData(TextureMappingTypeEnum TextureMappingType, object TextureMappingAlignment);
    IObjectCollection GetFaceColors(object Faces);
}