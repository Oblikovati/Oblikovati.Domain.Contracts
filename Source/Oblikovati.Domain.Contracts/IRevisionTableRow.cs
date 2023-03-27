namespace Oblikovati.Domain.Contracts;

public interface IRevisionTableRow : IList<IRevisionTableRow>
{

    IRevisionTable Parent { get; }
    IRevisionTableCell Item { get; }
    int Count { get; }
    double Height { get; set; }
    bool IsActiveRow { get; set; }
    bool Visible { get; set; }
    bool Custom { get; }
    IEnumerator GetEnumerator();
    void Delete();
    void Reposition(int TargetIndex, bool InsertBefore);
}
