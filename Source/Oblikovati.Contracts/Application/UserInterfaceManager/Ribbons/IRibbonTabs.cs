using DynamicData.Binding;
using System.Collections.ObjectModel;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.Ribbons;

public interface IRibbonTabs : IDictionary<string, IRibbonTab>
{
    IObservable<IRibbonTab> SelectedTab { get; }
    IRibbonTab Add(string DisplayName, string InternalName, Guid? ClientId = null,
        string? TargetTabInternalName = null, bool InsertBeforeTargetTab = false, bool Contextual = false);
}