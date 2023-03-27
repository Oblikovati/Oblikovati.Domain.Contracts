using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface ISearchBoxEventsSink_Event
{
    void add_OnStartSearch(SearchBoxEventsSink_OnStartSearchEventHandler handler);
    void remove_OnStartSearch(SearchBoxEventsSink_OnStartSearchEventHandler handler);
    void add_OnEndSearch(SearchBoxEventsSink_OnEndSearchEventHandler handler);
    void remove_OnEndSearch(SearchBoxEventsSink_OnEndSearchEventHandler handler);
    void add_OnStopSearch(SearchBoxEventsSink_OnStopSearchEventHandler handler);
    void remove_OnStopSearch(SearchBoxEventsSink_OnStopSearchEventHandler handler);
    void add_OnClearSearch(SearchBoxEventsSink_OnClearSearchEventHandler handler);
    void remove_OnClearSearch(SearchBoxEventsSink_OnClearSearchEventHandler handler);
}
