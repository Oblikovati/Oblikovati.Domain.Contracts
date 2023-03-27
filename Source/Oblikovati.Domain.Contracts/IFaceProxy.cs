using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFaceProxy
{

    ISurfaceBody Parent { get; }
    IPartFeature CreatedByFeature { get; }
    IObjectCollection _CreatedByFeatures { get; }
    IEdgeLoops EdgeLoops { get; }
    IEdges Edges { get; }
    IVertices Vertices { get; }
    IFaceShell FaceShell { get; }
    ISurfaceBody SurfaceBody { get; }
    bool IsParamReversed { get; }
    SurfaceTypeEnum SurfaceType { get; }
    object Surface { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    ISurfaceEvaluator Evaluator { get; }
    ISurfaceBody AlternateBody { get; }
    IAttributeSets AttributeSets { get; }
    int TransientKey { get; }
    IPoint PointOnFace { get; }
    ISketchEntity _CreatedFromCurve { get; }
    ITextureMaps TextureMaps { get; }
    IFaceCollection TangentiallyConnectedFaces { get; }
    int AssociativeID { get; set; }
    bool HasReferenceComponent { get; }
    object ReferencedEntity { get; }
    IReferenceComponent ReferenceComponent { get; }
    IObjectCollection ThreadInfos { get; }
    string InternalName { get; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    IFace NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void CalculateFacets(double Tolerance, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices);
    void GetExistingFacets(double ToleranceIndex, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices);
    void GetExistingFacetTolerances(out int ToleranceCount, out List<double> ExistingTolerances);
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out List<double> VertexCoordinates, out List<int> VertexIndices);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);
    void GetExistingStrokeTolerances(out int ToleranceCount, out List<double> ExistingTolerances);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetExistingFacetsAndTextureMap(double ToleranceIndex, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices, out List<double> TextureCoordinates);
    void CalculateFacetsAndTextureMap(double Tolerance, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices, out List<double> TextureCoordinates);
    IFace GetSourceFace(bool GetLeafSource);
    IPoint GetClosestPointTo(IPoint InputPoint);
    void CalculateFacetsWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices, out object TextureCoordinates);
    void GetExistingFacetsAndTextureMap2(double ChordalTolerance, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices, out List<double> TextureCoordinates, out List<int> IndexCountPerFace);
    void CalculateStrokesWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount, out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);
    void GetTextureScale(out double UScale, out double VScale);
}
