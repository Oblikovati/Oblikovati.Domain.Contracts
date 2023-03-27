namespace Oblikovati.Domain.Contracts;

public interface ICustomDictionary
{

    string Name { get; }
    string FullFileName { get; }
    void ImportWordsFromExistingDictionary(string FullFileName);
    void AddWord(string Word);
    void DeleteWord(string Word);
    void GetWords(ref List<string> Words);
    void Remove();
}
