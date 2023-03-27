using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ITitleBlock
{

    ISheet Parent { get; }
    ITitleBlockDefinition Definition { get; }
    TitleBlockLocationEnum Location { get; }
    IPoint2d Position { get; }
    IMatrix2d Transformation { get; }
    string Name { get; set; }
    IBox2d RangeBox { get; }
    void Delete();
    string GetResultText(ITextBox DefinitionText);
    void SetPromptResultText(ITextBox DefinitionText, string NewValue);
}
