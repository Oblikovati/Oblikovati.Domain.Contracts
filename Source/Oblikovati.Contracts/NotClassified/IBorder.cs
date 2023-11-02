using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.NotClassified;

public interface IBorder
{
    ISheet Parent { get; }
    IBorderDefinition Definition { get; }
    IBox2d RangeBox { get; }
    string Name { get; set; }
    void Delete();
    string GetResultText(ITextBox DefinitionText);
    void SetPromptResultText(ITextBox DefinitionText, string NewValue);
}