using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.FileManager;

public interface IFileLocations
{
    string Workspace { get; set; }
    bool _WorkspaceActive { get; set; }
    bool _LocalsActive { get; set; }
    bool _WorkgroupsActive { get; set; }
    string FileLocationsFilesDir { get; set; }
    string FileLocationsFile { get; set; }
    bool _CurrentSettingsDirty { get; }
    bool _Dirty { get; }
    string ContentCenterPath { get; set; }
    string TemplatesPath { get; set; }
    string DesignDataPath { get; set; }
    string PresetsPath { get; set; }
    void _Locals(out int NumLocals, ref List<string> Names, ref List<string> Paths);
    void _RemoveLocal(string Name);
    void _AddLocal(string Name, string Path, int Index);
    void Workgroups(out int NumWorkGroups, ref List<string> Names, ref List<string> Paths);
    void RemoveWorkgroup(string Name);
    void AddWorkgroup(string Name, string Path, int Index);
    void Libraries(out int NumLibraries, ref List<string> Names, ref List<string> Paths);
    void RemoveLibrary(string Name);
    void AddLibrary(string Name, string Path);
    string _GetLibraryVault(string LibraryName);
    void _SetLibraryVault(string LibraryName, string VaultPath);
    void _ApplyCurrentSettings();
    void _Save();
    void _SaveAs(string LocationsFile);
    void FindInLocations(string FullFileName, out string RepositoryName, out LocationTypeEnum Type);

    void FindLogicalInLocations(string RelativeFileName, string LibraryName, out string RepositoryName,
        out LocationTypeEnum Type);

    void ProjectFiles(out int NumProjectFiles, ref List<string> ProjectFileNamePaths);

    void GetVaultData(out string VaultServer, out string VaultName, out string VaultProject,
        out string StreamlineWatchFolder);

    void SetVaultData(string VaultServer, string VaultName, string VaultProject, string StreamlineWatchFolder);
}