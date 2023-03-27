namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumEdges
{
    void Next(uint nBodies, out IIRxEdge ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumEdges ppEnum);
}
