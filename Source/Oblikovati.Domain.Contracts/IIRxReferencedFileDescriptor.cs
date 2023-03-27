using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IIRxReferencedFileDescriptor
{
    DocumentTypeEnum DocumentType { get; }
    string DisplayName { get; }
    string FullFileName { get; }
    int FileSaveCounter { get; }
    object FileVersion { get; }
    IIRxFileAndReferences ReferencedDocument { get; }
    void GetLogicalFileName(out string pbstrRelativeFileName, out string pbstrLibraryName);
    void _PutLogicalFileName(string bstrRelativeFileName, string bstrLibraryName);
    void PutLogicalFileNameUsingFull(string bstrFullFileName);
    void GetCustomLogicalFileName(ref int pnSize, out IntPtr ppCustomLogicalFileName);
    void PutCustomLogicalFileName(int nSize, byte pCustomLogicalFileName);
}
