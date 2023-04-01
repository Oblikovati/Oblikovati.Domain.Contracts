namespace Oblikovati.Contracts.Application.DesignProjectManager;

public interface IProjectAssetLibrary
{
    string Name { get; }
    IDesignProject Parent { get; }
    string LibraryFilename { get; }
    void Activate();
    void Delete();
}