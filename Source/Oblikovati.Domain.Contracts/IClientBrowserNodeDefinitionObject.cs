using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IClientBrowserNodeDefinitionObject
{

    IDocument Parent { get; }
    bool BuiltIn { get; }
    string Label { get; }
    string StateIconToolTipText { get; set; }
    string ToolTipText { get; set; }
    bool Transient { get; }
    string DebugInfo { get; }
    BrowserNodeDisplayStateEnum DisplayState { get; set; }
    BrowserNodeDisplayStateEnum AdditionalDisplayState { get; set; }
    string AdditionalStateIconToolTipText { get; set; }
    bool Visible { get; set; }
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
