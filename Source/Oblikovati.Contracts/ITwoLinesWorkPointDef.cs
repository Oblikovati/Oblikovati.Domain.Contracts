namespace Oblikovati.Contracts;

public interface ITwoLinesWorkPointDef
{
    IWorkPoint Parent { get; }
    object Line1 { get; }
    object Line2 { get; }
    void GetData(out object Line1, out object Line2);
}