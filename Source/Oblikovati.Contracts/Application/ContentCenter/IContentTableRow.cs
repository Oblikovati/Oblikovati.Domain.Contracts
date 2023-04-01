namespace Oblikovati.Contracts.Application.ContentCenter;

public interface IContentTableRow : IList<IContentTableRow>
{
    int Index { get; }
    bool IsSuppressed { get; set; }
    IContentTableCell Item { get; }
    IContentFamily Parent { get; }
    string InternalName { get; }
    string ContentIdentifier { get; }
    string MemberRevision { get; }
    void Delete();

    string GetCellValue(object CellIndex, object CustomInput);
}