using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts;

public interface IDefaultBorder
{
    ISheet Parent { get; }
    IBorderDefinition Definition { get; }
    IBox2d RangeBox { get; }
    string Name { get; set; }
    int HorizontalZoneCount { get; }
    BorderLabelModeEnum HorizontalZoneLabelMode { get; }
    int VerticalZoneCount { get; }
    BorderLabelModeEnum VerticalZoneLabelMode { get; }
    bool LabelFromBottomRight { get; }
    bool DelimitZonesByLines { get; }
    double TopMargin { get; }
    double BottomMargin { get; }
    double LeftMargin { get; }
    double RightMargin { get; }
    double _BorderLineWidth { get; }
    string _Font { get; }
    double _TextLabelHeight { get; }
    bool Centermarks { get; }
    void Delete();
    string GetResultText(ITextBox DefinitionText);
    void SetPromptResultText(ITextBox DefinitionText, string NewValue);
}