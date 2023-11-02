namespace Oblikovati.Contracts.NotClassified;

public interface IGeneralNoteSymbolDefinitions : IList<IGeneralNoteSymbolDefinitions>
{
    IGeneralNoteSymbolDefinition Item { get; }


    IGeneralNoteSymbolDefinition Add(object SymbolDefinition, object TargetIndex, object InsertBefore);
}