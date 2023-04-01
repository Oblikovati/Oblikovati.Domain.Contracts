namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbonPanels : IList<IRibbonPanel>
{
    IRibbonPanel Add(string DisplayName, string InternalName, string? ClientId = null,
        string? TargetPanelInternalName = null, bool InsertBeforeTargetPanel = false);
}