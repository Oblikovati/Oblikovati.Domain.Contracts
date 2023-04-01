namespace Oblikovati.Contracts;

public interface ICategoryManager
{
    string GetCategory(string CategoryId, string LibraryId);
    string AddCategory(string ParentCategory, string NewCategoryXml, string LibraryId);
    void EditCategory(string CategoryXml, string LibraryId);
    void DeleteCategory(string CategoryId, string LibraryId);
    string GetCategoryStrings(string CategoryId, string LibraryId, string Language, bool EnumerationOnly);
    void EditCategoryStrings(string CategoryId, string LibraryId, string CategoryStrings);
    List<string> GetCategoryIcons(ref List<string> CategoryIds, string LibraryId);
    void EditCategoryIcon(string CategoryId, string LibraryId, string IconFile);
    string GetItem(string CategoryId);
}