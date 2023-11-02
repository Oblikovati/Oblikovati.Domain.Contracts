namespace Oblikovati.Contracts.NotClassified;

public interface IHoleTableRows : IList<IHoleTableRows>
{
    IHoleTableRow Item { get; }


    IHoleTableRow Add(object Hole);
}