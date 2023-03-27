using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFileDescriptor
{

    IFile Parent { get; }
    string FullFileName { get; }
    string RelativeFileName { get; }
    LocationTypeEnum LocationType { get; }
    string LibraryName { get; }
    IFile ReferencedFile { get; }
    FileTypeEnum ReferencedFileType { get; }
    int FileSaveCounter { get; }
    bool ReferenceMissing { get; }
    bool ReferenceDisabled { get; }
    bool ReferenceInternalNameDifferent { get; }
    bool ReferenceLocationDifferent { get; }
    string ResolvedFullFileName { get; }
    FileOwnershipEnum OwnershipType { get; }
    string ReferencedFileInternalName { get; }
    bool ReferenceReplaced { get; }
    List<byte> GetCustomLogicalFileName();
    void PutCustomLogicalFileName(List<byte> Value);
    void ReplaceReference(string FullFileName);
}
