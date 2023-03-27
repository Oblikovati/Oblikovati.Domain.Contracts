namespace Oblikovati.Domain.Contracts;

public interface ICustomDictionaries : IList<ICustomDictionaries>
{

    int Count { get; }
    ICustomDictionary Item { get; }
    IEnumerator GetEnumerator();
    ICustomDictionary Add(string Name);
    ICustomDictionary AddExisting(string FullFileName);
}
