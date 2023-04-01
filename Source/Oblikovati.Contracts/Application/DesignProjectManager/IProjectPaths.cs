namespace Oblikovati.Contracts.Application.DesignProjectManager;

public interface IProjectPaths : IList<IProjectPaths>
{
    IProjectPath Item { get; }
    IProjectPath Add(string Name, string Path, int TargetIndex);
    void AddFromFile(string ProjectFullFileName);
}