namespace Oblikovati.Domain.Contracts;

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
