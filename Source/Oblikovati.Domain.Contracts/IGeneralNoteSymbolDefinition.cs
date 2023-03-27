namespace Oblikovati.Domain.Contracts;

public interface IGeneralNoteSymbolDefinition
{

    IModelGeneralNoteDefinition Parent { get; }
    object SymbolDefinition { get; set; }
    void Delete();
}
