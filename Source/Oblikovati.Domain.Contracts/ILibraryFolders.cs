namespace Oblikovati.Domain.Contracts;

public interface ILibraryFolders : IList<ILibraryFolders>
{

    int Count { get; }
    ILibraryFolder Item { get; }
    IEnumerator GetEnumerator();
    ILibraryFolder Add(object Name);
}
