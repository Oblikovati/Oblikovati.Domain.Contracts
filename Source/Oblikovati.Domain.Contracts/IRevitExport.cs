namespace Oblikovati.Domain.Contracts;

public interface IRevitExport
{
    IAttributeSets AttributeSets { get; }
    IRevitExportDefinition Definition { get; set; }
    string FullFileName { get; }
    string Name { get; }
    IAssemblyComponentDefinition Parent { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void Update();
}
