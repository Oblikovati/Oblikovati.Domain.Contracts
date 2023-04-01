using Oblikovati.Contracts.ModelAnnotations;

namespace Oblikovati.Contracts;

public interface IGeneralNoteSymbolDefinition
{
    IModelGeneralNoteDefinition Parent { get; }
    object SymbolDefinition { get; set; }
    void Delete();
}