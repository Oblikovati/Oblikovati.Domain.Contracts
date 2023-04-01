namespace Oblikovati.Contracts.Application.GeneralOptions;

public interface ICustomDictionaries : IList<ICustomDictionaries>
{
    ICustomDictionary Item { get; }

    ICustomDictionary Add(string Name);
    ICustomDictionary AddExisting(string FullFileName);
}