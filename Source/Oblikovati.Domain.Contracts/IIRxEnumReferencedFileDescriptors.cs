namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumReferencedFileDescriptors
{
    void Next(uint nElems, out IIRxReferencedFileDescriptor ppElems, out uint pnElemsFetched);
    void Skip(uint nElems);
    void Reset();
    void Clone(out IIRxEnumReferencedFileDescriptors ppEnum);
}
