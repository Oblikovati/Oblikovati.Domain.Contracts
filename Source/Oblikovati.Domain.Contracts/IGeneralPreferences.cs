using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGeneralPreferences
{
    bool MultiUsersEnabled { get; set; }
    string TemplateDir { get; set; }
    bool DeferUpdate { get; set; }
    MultiUserModeEnum MultiUserMode { get; set; }
    bool MultiUserExternallyManaged { get; set; }
    int _NumberOfVersionsKept { get; set; }
    void _MinimizeFileSize(string FullFileName, int NumVersionsToKeep);
}
