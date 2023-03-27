namespace Oblikovati.Domain.Contracts;

public interface ICommand
{
    bool BuiltIn { get; }
    int Id { get; set; }
    string Caption { get; set; }
    string DescriptionText { get; set; }
    string ToolTipText { get; set; }
    bool Enabled { get; set; }
    bool Visible { get; set; }
    void Delete();
}
