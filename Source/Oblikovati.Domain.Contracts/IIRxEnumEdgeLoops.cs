namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumEdgeLoops
{
    void Next(uint nBodies, out IIRxEdgeLoop ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumEdgeLoops ppEnum);
}
