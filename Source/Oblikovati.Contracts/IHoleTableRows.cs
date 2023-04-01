namespace Oblikovati.Contracts;

public interface IHoleTableRows : IList<IHoleTableRows>
{
    IHoleTableRow Item { get; }


    IHoleTableRow Add(object Hole);
}