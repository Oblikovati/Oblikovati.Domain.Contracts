namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumApplicationAddIns
{
    void Next(uint nElems, out IIRxApplicationAddIn ppElems, out uint pnElemsFetched);
    void Skip(uint nElems);
    void Reset();
    void Clone(out IIRxEnumApplicationAddIns ppEnum);
}
