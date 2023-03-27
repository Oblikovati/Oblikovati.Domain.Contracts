using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IStyleEventsSink_Event
{
    void add_OnDelete(StyleEventsSink_OnDeleteEventHandler handler);
    void remove_OnDelete(StyleEventsSink_OnDeleteEventHandler handler);
    void add_OnNewStyle(StyleEventsSink_OnNewStyleEventHandler handler);
    void remove_OnNewStyle(StyleEventsSink_OnNewStyleEventHandler handler);
    void add_OnActivateStyle(StyleEventsSink_OnActivateStyleEventHandler handler);
    void remove_OnActivateStyle(StyleEventsSink_OnActivateStyleEventHandler handler);
    void add_OnStyleChange(StyleEventsSink_OnStyleChangeEventHandler handler);
    void remove_OnStyleChange(StyleEventsSink_OnStyleChangeEventHandler handler);
    void add_OnMigrateStyleLibrary(StyleEventsSink_OnMigrateStyleLibraryEventHandler handler);
    void remove_OnMigrateStyleLibrary(StyleEventsSink_OnMigrateStyleLibraryEventHandler handler);
}
