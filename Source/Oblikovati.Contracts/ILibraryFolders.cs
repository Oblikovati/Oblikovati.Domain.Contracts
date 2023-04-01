namespace Oblikovati.Contracts;

public interface ILibraryFolders : IList<ILibraryFolders>
{
    ILibraryFolder Item { get; }

    ILibraryFolder Add(object Name);
}