using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxReferencedOLEFileDescriptor
{
    OLEDocumentTypeEnum OLEDocumentType { get; }
    string LogicalName { get; }
    string DisplayName { get; }
    string FullFileName { get; }
    void Activate(OLEVerbEnum Verb, out object ppOLEDocumentObject);
}
