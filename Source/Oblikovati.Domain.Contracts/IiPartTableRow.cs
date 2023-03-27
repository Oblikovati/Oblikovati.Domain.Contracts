namespace Oblikovati.Domain.Contracts;

public interface IiPartTableRow : IList<IiPartTableRow>
{

    int Count { get; }
    IiPartTableCell Item { get; }
    IiPartFactory Parent { get; }
    string PartIdentifier { get; }
    string PartName { get; set; }
    int Index { get; }
    bool PartNameModifiable { get; }
    bool IsPartNameBasedOnMemberName { get; }
    string MemberName { get; }
    IAttributeSets AttributeSets { get; }
    IEnumerator GetEnumerator();
    void Delete();
    IiPartTableRow Copy(string NewMemberName);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
