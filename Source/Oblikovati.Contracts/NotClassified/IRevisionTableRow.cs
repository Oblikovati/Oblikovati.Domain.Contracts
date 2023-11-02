namespace Oblikovati.Contracts.NotClassified;

public interface IRevisionTableRow : IList<IRevisionTableRow>
{
    IRevisionTable Parent { get; }
    IRevisionTableCell Item { get; }

    double Height { get; set; }
    bool IsActiveRow { get; set; }
    bool Visible { get; set; }
    bool Custom { get; }

    void Delete();
    void Reposition(int TargetIndex, bool InsertBefore);
}