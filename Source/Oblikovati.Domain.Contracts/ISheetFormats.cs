namespace Oblikovati.Domain.Contracts;

public interface ISheetFormats : IList<ISheetFormats>
{

    ISheetFormat Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ISheetFormat Add(ISheet Sheet, string Name);
    ISheetFormat AddWithOptions(ISheet Sheet, string Name, object Options);
}
