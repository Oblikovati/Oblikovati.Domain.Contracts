using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Application.Headless;

public interface IHeadlessApplication : IApplicationBase, IInjectableSingletonEntity
{
    IHeadlessDocument Document { get; }
    IFileSaveAs FileSaveAs { get; }
    bool MultiUsersEnabled { get; set; }
    MultiUserModeEnum MultiUserMode { get; set; }
    bool MultiUserExternallyManaged { get; set; }
    bool DisplayAffinity { get; set; }
    bool IndirectReferences { get; set; }
    IHeadlessDocument Open(string FullDocumentName);
    IHeadlessDocument OpenWithOptions(string FullDocumentName, INameValueMap Options);
    void _DisplayHelpTopic(string FileName, string TopicName);
    void _DisplayHelpContext(string FileName, int Context);
    bool _GetStylesLibraryLockStatus(string StylesLibraryLocation);
    void _SetStylesLibraryLockStatus(string FileName, bool bLock);
}
