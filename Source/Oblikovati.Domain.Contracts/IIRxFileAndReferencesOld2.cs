using Oblikovati.Domain.Contracts.Enums;
using Oblikovati.Domain.Contracts.Structs;

namespace Oblikovati.Domain.Contracts;

public interface IIRxFileAndReferencesOld2 : IIRxFileAndReferencesOld
{
    DocumentTypeEnum DocumentType { get; }
    string DisplayName { get; set; }
    string FullFileName { get; }
    int FileSaveCounter { get; }
    object _FileVersion { get; }
    int _AppMajorVersionCreated { get; }
    int _AppMinorVersionCreated { get; }
    int _AppMajorVersionSaved { get; }
    int _AppMinorVersionSaved { get; }
    object FileVersions { get; }
    short NeedsMigrating { get; }
    short Dirty { get; set; }
    short ReservedForWrite { get; }
    short ReservedForWriteByMe { get; set; }
    string ReservedForWriteName { get; }
    string ReservedForWriteLogin { get; }
    int ReservedForWriteVersion { get; }
    _FILETIME ReservedForWriteTime { get; }
    IIRxEnumFileAndReferences ReferencedFiles { get; }
    IIRxEnumFileAndReferences AllReferencedFiles { get; }
    IIRxEnumReferencedFileDescriptors ReferencedFileDescriptors { get; }
    IIRxEnumReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    object ReferencedOLEFileDescriptors2 { get; }
    object _AssociatedFileDescriptors { get; }
    IIRxPropertySets PropertySets { get; }
    Guid InternalName { get; }
    void GetLocationFoundIn(out string pbstrLocationName, out LocationTypeEnum pLocationType);
}
