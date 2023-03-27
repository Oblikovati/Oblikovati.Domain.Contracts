namespace Oblikovati.Domain.Contracts;

public interface IViewList : IList<IViewList>
{
    int Count { get; }
    IView Item { get; }
    IEnumerator GetEnumerator();
    void Add(IView View);
    void Remove(IView View);
}
