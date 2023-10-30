namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbonPanels : IDictionary<string, IRibbonPanel>
{
    IRibbonPanel Add(string DisplayName, string InternalName, Guid? ClientId = null,
        string? TargetPanelInternalName = null, bool InsertBeforeTargetPanel = false);
}