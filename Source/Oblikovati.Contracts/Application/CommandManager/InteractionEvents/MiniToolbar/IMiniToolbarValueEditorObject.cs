using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.CommandManager.InteractionEvents.MiniToolbar;

public interface IMiniToolbarValueEditorObject
{
    IMiniToolbar Parent { get; }
    bool AutoHide { get; set; }
    MiniToolbarControlTypeEnum ControlType { get; }
    string DisplayName { get; set; }
    bool Enabled { get; set; }
    string InternalName { get; }
    string ToolTipText { get; set; }
    bool Visible { get; set; }
    int Index { get; }
    bool AllowToleranceEdit { get; set; }
    string Expression { get; set; }
    bool IsExpressionValid { get; }
    double MaximumValue { get; set; }
    double MinimumValue { get; set; }
    ModelValueTypeEnum ModelValueType { get; set; }
    object MostRecentValues { get; set; }
    int Precision { get; set; }
    ITolerance Tolerance { get; }
    ValueUnitsTypeEnum UnitsType { get; }
    double Value { get; set; }
    int Width { get; set; }
    bool CanValueBeEqualToMaximumValue { get; set; }
    bool CanValueBeEqualToMinimumValue { get; set; }
    bool AllowMeasure { get; set; }
    bool AllowShowDimensions { get; set; }
    UnitsTypeEnum DefaultUnits { get; set; }
    void Delete();
    void SetFocus();
}