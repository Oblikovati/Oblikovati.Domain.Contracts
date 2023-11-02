namespace Oblikovati.Contracts.NotClassified;

public interface IRevisionTableRows : IList<IRevisionTableRows>
{
    IRevisionTableRow Item { get; }


    IRevisionTableRow Add();
    IRevisionTableRow AddCustom(int TargetIndex, bool InsertBefore);
}