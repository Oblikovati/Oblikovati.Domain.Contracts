namespace Oblikovati.Contracts.NotClassified;

public interface ILibraryManager
{
    string GetServerLibraries(string LibraryId, bool EnumerationOnly);
    string GetLibraryStrings(string LibraryId, string Language, bool EnumerationOnly);
    List<string> GetLibraryIcons(ref List<string> LibraryIds);
}