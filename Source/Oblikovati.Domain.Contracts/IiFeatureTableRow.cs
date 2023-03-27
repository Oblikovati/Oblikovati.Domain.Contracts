namespace Oblikovati.Domain.Contracts;

public interface IiFeatureTableRow : IList<IiFeatureTableRow>
{
    IiFeatureTable Parent { get; }

    IiFeatureTableCell Item { get; }
    int Count { get; }
    string MemberName { get; }
    int Index { get; }
    IEnumerator GetEnumerator();
    void Delete();
    IiFeatureTableRow Copy();
}
