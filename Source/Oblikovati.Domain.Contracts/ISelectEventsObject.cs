using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISelectEventsObject
{
    IInteractionEvents Parent { get; }
    bool MouseMoveEnabled { get; set; }
    IObjectsEnumerator SelectedEntities { get; }
    bool SingleSelectEnabled { get; set; }
    bool WindowSelectEnabled { get; set; }
    bool IgnoreProfileInnerLoops { get; set; }
    IComponentOccurrence RestrictSelectionToOccurrence { set; }
    bool PreSelectBurnThrough { get; set; }
    bool Enabled { get; set; }
    bool ExpressSelectionEnabled { get; set; }
    _PreSelectionTypeEnum _PreSelectionType { get; }
    void AddSelectionFilter(SelectionFilterEnum Filter);
    void ClearSelectionFilter();
    void ResetSelections();
    void AddToSelectedEntities(object ItemObject);
    void RemoveFromSelectedEntities(object ItemObject);
    void AddWindowSelectionFilter(SelectionFilterEnum Filter);
    void ClearWindowSelectionFilter();
}
