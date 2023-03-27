namespace Oblikovati.Domain.Contracts;

public interface IProjectPaths : IList<IProjectPaths>
{

    IProjectPath Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IProjectPath Add(string Name, string Path, int TargetIndex);
    void AddFromFile(string ProjectFullFileName);
    void Clear();
}
