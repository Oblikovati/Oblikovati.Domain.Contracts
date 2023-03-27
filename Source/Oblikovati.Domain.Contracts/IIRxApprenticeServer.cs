namespace Oblikovati.Domain.Contracts;

public interface IIRxApprenticeServer : IIRxApprenticeServerOld
{
    IIRxComponentDocument Document { get; }
    IIRxFileAndReferences FileAndReferences { get; }
    IIRxFileLocations FileLocations { get; }
    IIRxFileSaveAs FileSaveAs { get; }
    short MultiUsersEnabled { get; set; }
    int _NumberOfVersionsKept { get; set; }
    int _MajorVersion { get; }
    int _MinorVersion { get; }
    IIRxTransientGeometry TransientGeometry { get; }
    IIRxComponentDocument Open(string FullFileName);
    void Close();
    void _MinimizeFileSize(string FullFileName, int NumVersionsToKeep);
    void _FileAlreadyOpen(string FullFileName, out short pbAlreadyOpen, out short pbOpenInThisProcess);
}
