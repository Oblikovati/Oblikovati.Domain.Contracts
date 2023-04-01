namespace Oblikovati.Contracts;

public interface IPartsListRows : IList<IPartsListRows>
{
    IPartsListRow Item { get; }


    IPartsListRow Add(int TargetIndex, bool InsertBefore);
}