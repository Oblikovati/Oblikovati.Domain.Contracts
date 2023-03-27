namespace Oblikovati.Domain.Contracts;

public interface IIRxFacets : IIRxFacetsOld
{
    void GetFacets(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, out IntPtr ppNormals, ref uint pdwNumFacets, out IntPtr ppVertexIndices);
    void GetExistingTolerances(ref uint pdwNumTols, out IntPtr ppTols);
    void GetExistingFacets(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, out IntPtr ppNormals, ref uint pdwNumFacets, out IntPtr ppVertexIndices);
    void GetExistingFacetsAndTextureMap(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, out IntPtr ppNormals, ref uint pdwNumFacets, out IntPtr ppVertexIndices, out IntPtr ppTextureCoordinates);
    void CalculateFacetsAndTextureMap(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, out IntPtr ppNormals, ref uint pdwNumFacets, out IntPtr ppVertexIndices, out IntPtr ppTextureCoordinates);
    void CalculateFacetsWithOptions(double ChordalTolerance, INameValueMap Options, ref uint VertexCount, ref uint FacetCount, out IntPtr VertexCoordinates, out IntPtr NormalVectors, out IntPtr VertexIndices, out IntPtr TextureCoordinates);
    void GetExistingFacetsAndTextureMap2(double ChordalTolerance, ref uint VertexCount, ref uint FacetCount, ref uint FaceCount, out IntPtr VertexCoordinates, out IntPtr NormalVectors, out IntPtr VertexIndices, out IntPtr TextureCoordinates, out IntPtr IndexCountPerFace);
}
