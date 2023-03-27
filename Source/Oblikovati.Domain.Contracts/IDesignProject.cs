using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDesignProject
{

    string FullFileName { get; }
    IContentCenterConfiguration ContentCenterConfiguration { get; }
    StylesLibraryAccessEnum StylesLibraryAccess { get; set; }
    IIntentConfiguration IntentConfiguration { get; }
    string ContentCenterPath { get; set; }
    bool ContentCenterPathOverridden { get; set; }
    DateTime CreationTime { get; set; }
    string DesignDataPath { get; set; }
    bool DesignDataPathOverridden { get; set; }
    IProjectPaths FrequentlyUsedPaths { get; }
    string ImportedComponentsFolderName { get; set; }
    string ImportedTopLevelAssembliesFolderName { get; set; }
    string IncludedProject { get; set; }
    IProjectPaths LibraryPaths { get; }
    string Name { get; set; }
    int OldVersionsToKeep { get; set; }
    string Owner { get; set; }
    IDesignProjectManager Parent { get; }
    MultiUserModeEnum ProjectType { get; set; }
    string ReleaseId { get; set; }
    object Shortcuts { get; set; }
    string TemplatesPath { get; set; }
    bool TemplatesPathOverridden { get; set; }
    bool UsingUniqueFileNames { get; set; }
    string VaultName { get; set; }
    string VaultPublishPath { get; set; }
    string VaultServer { get; set; }
    string VaultVirtualPath { get; set; }
    IProjectPaths WorkgroupPaths { get; }
    string WorkspacePath { get; set; }
    IProjectAssetLibrary ActiveAppearanceLibrary { get; }
    IProjectAssetLibrary ActiveMaterialLibrary { get; }
    IProjectAssetLibraries AppearanceLibraries { get; }
    IProjectAssetLibraries MaterialLibraries { get; }
    string PresetsPath { get; set; }
    bool PresetsPathOverridden { get; set; }
    void Save();
    string GetCustomSection(string Name);
    string GetIncludedCustomSection(string Name);
    void Remove();
    void SetCustomSection(string Name, string CustomSection);
    void Activate(bool SetAsDefaultProject = false);
}
