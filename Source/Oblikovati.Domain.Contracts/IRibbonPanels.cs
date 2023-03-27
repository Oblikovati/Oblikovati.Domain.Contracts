namespace Oblikovati.Domain.Contracts;

public interface IRibbonPanels : IList<IRibbonPanel>
{
    public IRibbonPanel this[string index] { get; }
    IRibbonPanel Add(string DisplayName, string InternalName, string ClientId = null, string TargetPanelInternalName = null, bool InsertBeforeTargetPanel = false);
}
