namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumVertices
{
    void Next(uint nBodies, out IIRxVertex ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumVertices ppEnum);
}
