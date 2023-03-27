using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ICommandBarControls : IList<ICommandBarControl>
{
    ICommandBarControl _Add(BarControlTypeEnum Type, object Command, object Before, object Temporary);
    ICommandBarControl Add(BarControlTypeEnum Type, object ControlDefinition, object Before);
    ICommandBarControl AddButton(IButtonDefinition ButtonDefinition, int Before);
    ICommandBarControl AddMacro(IMacroControlDefinition MacroControlDefinition, int Before);
    ICommandBarControl AddComboBox(IComboBoxDefinition ComboBoxDefinition, int Before);
    ICommandBarControl AddButtonPopup(ICommandBar CommandBar, object DisplayedControl, int Before);
    ICommandBarControl AddSplitButton(ICommandBar CommandBar, object DisplayedControl, int Before);
    ICommandBarControl AddSplitButtonMRU(ICommandBar CommandBar, object DisplayedControl, int Before);
    ICommandBarControl AddPopup(ICommandBar CommandBar, int Before);
}
