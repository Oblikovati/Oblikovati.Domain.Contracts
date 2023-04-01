using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface ISearchBoxEventsSink
{
    void OnStartSearch(out HandlingCodeEnum HandlingCode);
    void OnEndSearch(INameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
    void OnStopSearch(INameValueMap SearchResult, out HandlingCodeEnum HandlingCode);
    void OnClearSearch(out HandlingCodeEnum HandlingCode);
}