using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface IClientBrowserNodeDefinition : IBrowserNodeDefinition
{
    int Id { get; }
    IClientNodeResource Icon { get; set; }
    IAttributeSets AttributeSets { get; }
    IClientNodeResource ExpandedIcon { get; set; }
    IClientNodeResource StateIcon { get; set; }
    bool IsReferenced { get; }
    void Delete();
    void SetLabel(string Label);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}