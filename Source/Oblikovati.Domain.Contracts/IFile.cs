using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

/// <summary>The File object represents file on disk.</summary>
public interface IFile
{

    object AvailableDocuments { get; }
    string FullFileName { get; set; }
    IFileDescriptorsEnumerator ReferencedFileDescriptors { get; }
    IFilesEnumerator ReferencedFiles { get; }
    IFilesEnumerator ReferencingFiles { get; }
    IFilesEnumerator AllReferencedFiles { get; }
    string InternalName { get; }
    int FileSaveCounter { get; }
    FileOwnershipEnum OwnershipType { get; }
    string RevisionId { get; }
    string DatabaseRevisionId { get; }
    bool HasLoadedDocuments { get; }
    bool HasReferencingFiles { get; }
}
