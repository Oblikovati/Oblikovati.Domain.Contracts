namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IComboBoxDefinitionObject : IControlDefinition
{
    int DropDownWidth { get; set; }
    int ListCount { get; }
    int ListIndex { get; set; }
    string ListItem { get; set; }
    string Text { get; }
    void AddItem(string Item, int Index);
    void RemoveItem(int Index);
    void Clear();
}