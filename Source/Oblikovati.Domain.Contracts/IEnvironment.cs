using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IEnvironment
{
    string InternalName { get; }
    string ClientId { get; }
    string DisplayName { get; set; }
    ICommandBar DefaultMenuBar { get; set; }
    ICommandBar DefaultToolBar { get; set; }
    bool BuiltIn { get; }
    IDisabledCommandList DisabledCommandList { get; }
    CommandTypesEnum DisabledCommandTypes { get; set; }
    ICommandBarList ContextMenuList { get; }
    IPanelBar PanelBar { get; }
    List<string> AdditionalVisibleRibbonTabs { get; set; }
    string DefaultRibbonTab { get; set; }
    bool InheritAllRibbonTabs { get; set; }
    IRibbon Ribbon { get; }
    IRadialMarkingMenus RadialMarkingMenus { get; }
    object EnabledCommandList { get; set; }
    string ExitDisplayName { get; set; }
    bool PreserveWhenSwitchModelState { get; set; }
    void Delete();
    IRadialMarkingMenu GetRadialMarkingMenu(object ObjectType);
}
