namespace Oblikovati.Domain.Contracts;

public interface IContentTableRow : IList<IContentTableRow>
{

    int Count { get; }
    int Index { get; }
    bool IsSuppressed { get; set; }
    IContentTableCell Item { get; }
    IContentFamily Parent { get; }
    string InternalName { get; }
    string ContentIdentifier { get; }
    string MemberRevision { get; }
    void Delete();
    IEnumerator GetEnumerator();
    string GetCellValue(object CellIndex, object CustomInput);
}
