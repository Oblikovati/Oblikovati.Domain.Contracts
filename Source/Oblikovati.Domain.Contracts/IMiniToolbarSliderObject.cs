using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IMiniToolbarSliderObject
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
    double Maximum { get; set; }
    double Minimum { get; set; }
    int NumberOfTicks { get; set; }
    int StepsBetweenTicks { get; set; }
    double Value { get; set; }
    ValueTypeEnum ValueType { get; set; }
    int Width { get; set; }
    void Delete();
}
