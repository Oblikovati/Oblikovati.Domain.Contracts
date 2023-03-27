namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumFileAndReferences
{
    void Next(uint nElems, out IIRxFileAndReferences ppElems, out uint pnElemsFetched);
    void Skip(uint nElems);
    void Reset();
    void Clone(out IIRxEnumFileAndReferences ppEnum);
}
