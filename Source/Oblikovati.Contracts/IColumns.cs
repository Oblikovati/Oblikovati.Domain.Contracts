namespace Oblikovati.Contracts;

public interface IColumns : IList<IColumns>
{
    IColumn Item { get; }


    IColumn Add(string Title, int TargetIndex, bool InsertBefore, object Width);
}