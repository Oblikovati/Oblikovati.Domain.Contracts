namespace Oblikovati.Domain.Contracts;

public interface IGeneralNoteSymbolDefinitions : IList<IGeneralNoteSymbolDefinitions>
{

    IGeneralNoteSymbolDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IGeneralNoteSymbolDefinition Add(object SymbolDefinition, object TargetIndex, object InsertBefore);
}
