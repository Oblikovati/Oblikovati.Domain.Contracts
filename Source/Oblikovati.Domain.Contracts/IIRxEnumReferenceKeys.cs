namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumReferenceKeys
{
    void Next(uint dwNumElems, out IIRxReferenceKey ppElems, out uint pdwNumElemsFetched);
    void Skip(uint dwNumElems);
    void Reset();
    void Clone(out IIRxEnumReferenceKeys ppEnum);
}
