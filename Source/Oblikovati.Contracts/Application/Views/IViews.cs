namespace Oblikovati.Contracts.Application.Views;

public interface IViews : IList<IView>, IInjectableSingletonEntity
{
    IView Add();
}