namespace Oblikovati.Contracts.Application.DesignProjectManager;

public interface IProjectAssetLibraries : IList<IProjectAssetLibraries>
{
    IProjectAssetLibrary Item { get; }

    IProjectAssetLibrary Add(string LibraryFilename);
}