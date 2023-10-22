using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IReferencedFileDescriptor
{
    DocumentType DocumentType { get; }
    string DisplayName { get; }
    string FullFileName { get; }
    int FileSaveCounter { get; }
    object ReferencedDocument { get; }
    ReferenceStatusEnum ReferenceStatus { get; }
    IDocumentDescriptor DocumentDescriptor { get; }
    bool DifferentDocument { get; }
    bool DocumentFound { get; }
    void GetLogicalFileName(out string RelativeFileName, out string LibraryName);
    void PutLogicalFileNameUsingFull(string FullFileName);
    List<byte> GetCustomLogicalFileName();
    void PutCustomLogicalFileName(ref List<byte> CustomLogicalFileName);
    void _PutLogicalFileName(string RelativeFileName, string LibraryName);
    void PutLogicalFileNameUsingFullSpl(string FullFileName);
}