namespace Oblikovati.Domain.Contracts;

public interface IIRxStrokes : IIRxStrokesOld
{
    void GetStrokes(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, ref uint pdwNumSegments, out IntPtr ppVertexIndices);
    void GetExistingTolerances(ref uint pdwNumTols, out IntPtr ppTols);
    void GetExistingStrokes(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, ref uint pdwNumPolyLines, out IntPtr ppPolyLineLengths);
    void CalculateStrokesWithOptions(double ChordalTolerance, INameValueMap Options, ref uint VertexCount, out IntPtr VertexCoordinates, ref uint PolylineCount, out IntPtr PolylineLengths);
}
