namespace Oblikovati.Contracts.NotClassified;

public interface IRow : IList<IRow>
{
    ICustomTable Parent { get; }
    ICell Item { get; }

    double Height { get; set; }
    bool Visible { get; set; }

    void Delete();
    void Reposition(int TargetIndex, bool InsertBefore);
}