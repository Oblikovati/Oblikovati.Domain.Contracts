﻿using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationFace
{
    IPresentationEdgesEnumerator Edges { get; }
    ISurfaceEvaluator Evaluator { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    bool IsParamReversed { get; }
    IPoint PointOnFace { get; }
    IPresentationBody PresentationBody { get; }
    IPresentationVerticesEnumerator Vertices { get; }
    IPresentationBody Parent { get; }

    void CalculateFacets(double Tolerance, out int VertexCount, out int FacetCount, out List<double> VertexCoordinates,
        out List<double> NormalVectors, out List<int> VertexIndices);

    void GetExistingFacets(double ToleranceIndex, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices);

    void GetExistingFacetTolerances(out int ToleranceCount, out List<double> ExistingTolerances);

    void CalculateFacetsAndTextureMap(double Tolerance, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices,
        out List<double> TextureCoordinates);

    void CalculateFacetsWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount,
        out int FacetCount, out List<double> VertexCoordinates, out List<double> NormalVectors,
        out List<int> VertexIndices, out object TextureCoordinates);

    void GetExistingFacetsAndTextureMap(double ToleranceIndex, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices,
        out List<double> TextureCoordinates);

    void GetExistingFacetsAndTextureMap2(double ChordalTolerance, out int VertexCount, out int FacetCount,
        out List<double> VertexCoordinates, out List<double> NormalVectors, out List<int> VertexIndices,
        out List<double> TextureCoordinates, out List<int> IndexCountPerFace);

    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount,
        out List<double> VertexCoordinates, out List<int> VertexIndices);

    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out List<double> VertexCoordinates,
        out int PolylineCount, out List<int> PolylineLengths);

    void GetExistingStrokeTolerances(out int ToleranceCount, out List<double> ExistingTolerances);

    void CalculateStrokesWithOptions(double ChordalTolerance, INameValueMap Options, out int VertexCount,
        out List<double> VertexCoordinates, out int PolylineCount, out List<int> PolylineLengths);
}