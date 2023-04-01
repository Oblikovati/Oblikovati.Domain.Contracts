using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.DesignProjectManager;

public interface IDesignProjectManager : IInjectableSingletonEntity
{
    IDesignProjects DesignProjects { get; }
    IDesignProject ActiveDesignProject { get; }

    bool IsFileInActiveProject(string FileName, out LocationTypeEnum ProjectPathType, out string ProjectPathName);
    string ResolveFile(string SourcePath, string DestinationFileName, object Options);

    IProjectOptionsButton AddOptionsButton(string ClientId, string DisplayName, string ToolTipText,
        object StandardIcon);
}