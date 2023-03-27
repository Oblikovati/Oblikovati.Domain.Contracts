using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IUserInterfaceEventsSink_Event
{
    void add_OnResetEnvironments(UserInterfaceEventsSink_OnResetEnvironmentsEventHandler handler);
    void remove_OnResetEnvironments(UserInterfaceEventsSink_OnResetEnvironmentsEventHandler handler);
    void add_OnResetCommandBars(UserInterfaceEventsSink_OnResetCommandBarsEventHandler handler);
    void remove_OnResetCommandBars(UserInterfaceEventsSink_OnResetCommandBarsEventHandler handler);
    void add_OnEnvironmentChange(UserInterfaceEventsSink_OnEnvironmentChangeEventHandler handler);
    void remove_OnEnvironmentChange(UserInterfaceEventsSink_OnEnvironmentChangeEventHandler handler);
    void add_OnResetShortcuts(UserInterfaceEventsSink_OnResetShortcutsEventHandler handler);
    void remove_OnResetShortcuts(UserInterfaceEventsSink_OnResetShortcutsEventHandler handler);
    void add_OnResetRibbonInterface(UserInterfaceEventsSink_OnResetRibbonInterfaceEventHandler handler);
    void remove_OnResetRibbonInterface(UserInterfaceEventsSink_OnResetRibbonInterfaceEventHandler handler);
    void add_OnResetMarkingMenu(UserInterfaceEventsSink_OnResetMarkingMenuEventHandler handler);
    void remove_OnResetMarkingMenu(UserInterfaceEventsSink_OnResetMarkingMenuEventHandler handler);
    void add_OnResetOblikovatiLayout(UserInterfaceEventsSink_OnResetOblikovatiLayoutEventHandler handler);
    void remove_OnResetOblikovatiLayout(UserInterfaceEventsSink_OnResetOblikovatiLayoutEventHandler handler);
}
