namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumSurfaceBodies
{
    void Next(uint nBodies, out IIRxSurfaceBody ppBodies, out uint pnBodiesFetched);
    void Skip(uint nCurves);
    void Reset();
    void Clone(out IIRxEnumSurfaceBodies ppEnum);
}
