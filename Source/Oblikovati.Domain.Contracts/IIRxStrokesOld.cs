namespace Oblikovati.Domain.Contracts;

public interface IIRxStrokesOld
{
    void GetStrokes(double ChordalHeightTol, ref uint pdwNumVertices, out IntPtr ppVertices, ref uint pdwNumSegments, out IntPtr ppVertexIndices);
}
