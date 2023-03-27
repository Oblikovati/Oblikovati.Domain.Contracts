using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISearchBoxEventsSink
{
    void OnStartSearch(out HandlingCodeEnum HandlingCode);
    void OnEndSearch(INameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
    void OnStopSearch(INameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
    void OnClearSearch(out HandlingCodeEnum HandlingCode);
}
