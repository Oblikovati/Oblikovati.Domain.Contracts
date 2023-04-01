namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IProperty
{
    IPropertySet Parent { get; }
    int PropId { get; }
    string Name { get; }
    object Value { get; set; }
    bool Dirty { get; }
    string DisplayName { get; set; }
    string Expression { get; set; }
    void Delete();
}