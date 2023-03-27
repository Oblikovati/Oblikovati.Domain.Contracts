namespace Oblikovati.Domain.Contracts;

public interface IIRxVertex
{
    IIRxEnumEdges Edges { get; }
    IIRxEnumFaces Faces { get; }
    void GetPoint(out List<double> pPoint);
}
