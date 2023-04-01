namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IPropertySet : IList<IPropertySet>
{
    IPropertySets Parent { get; }
    string DisplayName { get; set; }
    string InternalName { get; }
    IProperty Item { get; }
    IProperty ItemByPropId { get; }

    bool Dirty { get; }
    string Name { get; }
    int _CodePage { get; }
    int _Locale { get; }
    IProperty Add(object PropValue, object Name, object PropId);
    void Delete();

    void GetPropertyInfo(out List<int> Ids, out List<string> Names, out List<object> Values);
}