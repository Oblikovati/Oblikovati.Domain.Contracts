namespace Oblikovati.Domain.Contracts;

public interface IIRxFacetsOld
{
    void GetFacets(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, out IntPtr ppNormals, ref uint pdwNumFacets, out IntPtr ppVertexIndices);
}
