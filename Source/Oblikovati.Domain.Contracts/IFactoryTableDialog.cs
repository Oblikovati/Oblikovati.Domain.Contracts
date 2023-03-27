namespace Oblikovati.Domain.Contracts;

public interface IFactoryTableDialog
{
    string DialogTitle { get; set; }
    string FullFileName { get; set; }
    string DestinationFileName { get; set; }
    int ActiveTabIndex { get; set; }
    bool IsCustomFactory { get; }
    int SelectedTableRow { get; }
    List<string> CustomInput { get; }
    void Show();
}
