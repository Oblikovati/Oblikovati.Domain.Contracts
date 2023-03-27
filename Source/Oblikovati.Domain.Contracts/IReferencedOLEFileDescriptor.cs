using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IReferencedOLEFileDescriptor
{


    OLEDocumentTypeEnum OLEDocumentType { get; }
    string LogicalName { get; }
    string DisplayName { get; set; }
    string FullFileName { get; }
    ReferenceStatusEnum ReferenceStatus { get; }
    object LastKnownFileTime { get; }
    IFileDescriptor FileDescriptor { get; }
    bool BrowserVisible { get; set; }
    IAttributeSets AttributeSets { get; }
    bool Visible { get; set; }
    IntPtr ReferenceMonitoring { get; set; }
    void Activate(OLEVerbEnum Verb, out object OLEDocumentObject);
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
