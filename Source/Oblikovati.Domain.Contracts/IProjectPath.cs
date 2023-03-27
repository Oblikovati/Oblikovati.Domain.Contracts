namespace Oblikovati.Domain.Contracts;

public interface IProjectPath
{

    string Name { get; set; }
    IDesignProject Parent { get; }
    string Path { get; set; }
    void Delete();
}
