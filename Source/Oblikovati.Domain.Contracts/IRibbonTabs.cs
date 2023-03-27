namespace Oblikovati.Domain.Contracts;

public interface IRibbonTabs : IList<IRibbonTab>
{
    public IRibbonTab this[string index] { get; }
    IRibbonTab Add(string DisplayName, string InternalName, string ClientId = null, string TargetTabInternalName = null, bool InsertBeforeTargetTab = false, bool Contextual = false);
}
