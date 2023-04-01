namespace Oblikovati.Contracts.Application.Views;

public interface IViewList : IList<IViewList>
{
    IView Item { get; }

    void Add(IView View);
    void Remove(IView View);
}