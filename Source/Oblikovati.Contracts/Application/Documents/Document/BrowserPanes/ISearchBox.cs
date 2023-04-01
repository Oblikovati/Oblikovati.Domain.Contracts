using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;

public interface ISearchBox
{
    IBrowserPane Parent { get; }
    ISearchBoxEvents SearchBoxEvents { get; }
    bool Enabled { get; set; }
    SearchBoxFilterEnum SearchFilter { get; }
    string SearchText { get; }
    bool Visible { get; set; }
    void Search(string SearchText, object SearchOptions);
}