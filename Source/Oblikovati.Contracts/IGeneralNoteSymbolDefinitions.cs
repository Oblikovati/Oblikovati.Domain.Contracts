namespace Oblikovati.Contracts;

public interface IGeneralNoteSymbolDefinitions : IList<IGeneralNoteSymbolDefinitions>
{
    IGeneralNoteSymbolDefinition Item { get; }


    IGeneralNoteSymbolDefinition Add(object SymbolDefinition, object TargetIndex, object InsertBefore);
}