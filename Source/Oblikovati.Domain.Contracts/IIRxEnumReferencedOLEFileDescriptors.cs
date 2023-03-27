namespace Oblikovati.Domain.Contracts;

public interface IIRxEnumReferencedOLEFileDescriptors
{
    void Next(uint nElems, out IIRxReferencedOLEFileDescriptor ppElems, out uint pnElemsFetched);
    void Skip(uint nElems);
    void Reset();
    void Clone(out IIRxEnumReferencedOLEFileDescriptors ppEnum);
}
