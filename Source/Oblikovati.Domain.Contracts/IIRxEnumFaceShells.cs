namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumFaceShells
{
    void Next(uint nBodies, out IIRxFaceShell ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumFaceShells ppEnum);
}
