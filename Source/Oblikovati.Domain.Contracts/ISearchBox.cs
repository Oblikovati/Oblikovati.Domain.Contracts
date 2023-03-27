using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
