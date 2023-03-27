namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumFaces
{
    void Next(uint nBodies, out IIRxFace ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumFaces ppEnum);
}
