namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IPropertySets : IList<IPropertySets>
{
    IPropertySet Item { get; }

    bool Dirty { get; }
    IPropertySet Add(string Name, object InternalName);

    void RefreshFromFile();
    void FlushToFile();
    bool PropertySetExists(string PropertySetName, out object PropertySet);
}