namespace Oblikovati.Domain.Contracts;

public interface IPropertySets : IList<IPropertySets>
{

    IPropertySet Item { get; }
    int Count { get; }
    bool Dirty { get; }
    IPropertySet Add(string Name, object InternalName);
    IEnumerator GetEnumerator();
    void RefreshFromFile();
    void FlushToFile();
    bool PropertySetExists(string PropertySetName, out object PropertySet);
}
