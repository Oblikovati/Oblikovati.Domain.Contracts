namespace Oblikovati.Domain.Contracts;

public interface IViews : IList<IView> , IInjectableSingletonEntity
{

    IView Add();
}
