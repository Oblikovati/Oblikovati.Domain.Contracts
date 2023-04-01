namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbonTabs : IList<IRibbonTab>
{
    IRibbonTab Add(string DisplayName, string InternalName, string? ClientId = null,
        string? TargetTabInternalName = null, bool InsertBeforeTargetTab = false, bool Contextual = false);
}