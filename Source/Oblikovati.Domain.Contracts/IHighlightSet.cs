namespace Oblikovati.Domain.Contracts;

public interface IHighlightSet : IList<IHighlightSet>
{
    object Item { get; }
    int Count { get; }
    IColor Color { get; set; }
    void Remove(object Index);
    void Clear();
    void Delete();
    void AddItem(object Entity);
    void GetColor(out int Red, out int Green, out int Blue);
    void SetColor(int Red, int Green, int Blue);
    IEnumerator GetEnumerator();
    void AddMultipleItems(IObjectCollection Entities);
}
