namespace Oblikovati.Contracts.Application.DesignProjectManager;

public interface IProjectPath
{
    string Name { get; set; }
    IDesignProject Parent { get; }
    string Path { get; set; }
    void Delete();
}