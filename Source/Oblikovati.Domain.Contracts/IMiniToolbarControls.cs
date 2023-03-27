using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarControls : IList<IMiniToolbarControls>
{
    int Count { get; }
    IMiniToolbarControl Item { get; }
    IEnumerator GetEnumerator();
    IMiniToolbarButton AddButton(string InternalName, string DisplayName, string ToolTipText, object StandardIcon, object LargeIcon);
    IMiniToolbarCheckBox AddCheckBox(string InternalName, string DisplayName, string ToolTipText, bool Checked, object StandardIcon, object LargeIcon);
    IMiniToolbarDropdown AddDropdown(string InternalName, bool ShowIcon, bool ShowText, bool HasMRUBehavior, bool IsSplitButton);
    IMiniToolbarComboBox AddComboBox(string InternalName, bool ShowIcon, bool ShowText, int Width);
    IMiniToolbarControl AddLabel(string InternalName, string Text, string ToolTipText, object StandardIcon, object LargeIcon);
    IMiniToolbarControl AddNewLine();
    IMiniToolbarControl AddSeparator();
    IMiniToolbarValueEditor AddValueEditor(string InternalName, string ToolTipText, ValueUnitsTypeEnum UnitsType, string Expression, string DisplayName, int Width, object StandardIcon, object LargeIcon);
    IMiniToolbarSlider AddSlider(string InternalName, string DisplayName, string ToolTipText, ValueTypeEnum ValueType, double Maximum, double Minimum, int NumberOfTicks, int StepsBetweenTicks, int Width);
    IMiniToolbarTextEditor AddTextEditor(string InternalName, string ToolTipText, string TextValue, string DisplayName, int Width, int Height, object StandardIcon, object LargeIcon);
    IMiniToolbarTextBox AddTextBox(string InternalName, string TextValue, string DisplayName, string ToolTipText);
}
