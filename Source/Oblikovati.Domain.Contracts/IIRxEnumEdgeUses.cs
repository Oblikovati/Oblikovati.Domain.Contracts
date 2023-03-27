namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumEdgeUses
{
    void Next(uint nBodies, out IIRxEdgeUse ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumEdgeUses ppEnum);
}
