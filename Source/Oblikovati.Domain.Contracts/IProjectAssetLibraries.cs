namespace Oblikovati.Domain.Contracts;

public interface IProjectAssetLibraries : IList<IProjectAssetLibraries>
{

    int Count { get; }
    IProjectAssetLibrary Item { get; }
    IEnumerator GetEnumerator();
    IProjectAssetLibrary Add(string LibraryFilename);
}
