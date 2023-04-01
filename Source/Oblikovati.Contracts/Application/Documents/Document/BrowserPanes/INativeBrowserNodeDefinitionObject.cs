using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface INativeBrowserNodeDefinitionObject
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
    IClientNodeResource OverrideIcon { get; set; }
    object NativeObject { get; }
    IClientNodeResource OverrideExpandedIcon { get; set; }
    IClientNodeResource OverrideStateIcon { get; set; }
    bool LabelModified { get; }
}