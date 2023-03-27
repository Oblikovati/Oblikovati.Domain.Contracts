namespace Oblikovati.Domain.Contracts;

public interface IRow : IList<IRow>
{

    ICustomTable Parent { get; }
    ICell Item { get; }
    int Count { get; }
    double Height { get; set; }
    bool Visible { get; set; }
    IEnumerator GetEnumerator();
    void Delete();
    void Reposition(int TargetIndex, bool InsertBefore);
}
