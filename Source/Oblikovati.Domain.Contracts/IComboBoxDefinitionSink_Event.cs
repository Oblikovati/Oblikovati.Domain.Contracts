using Oblikovati.Domain.Contracts.Delegates;

namespace Oblikovati.Domain.Contracts;

public interface IComboBoxDefinitionSink_Event
{
    void add_OnSelect(ComboBoxDefinitionSink_OnSelectEventHandler handler);
    void remove_OnSelect(ComboBoxDefinitionSink_OnSelectEventHandler handler);
    void add_OnHelp(ComboBoxDefinitionSink_OnHelpEventHandler handler);
    void remove_OnHelp(ComboBoxDefinitionSink_OnHelpEventHandler handler);
}
