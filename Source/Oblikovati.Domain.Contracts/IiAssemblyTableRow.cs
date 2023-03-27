namespace Oblikovati.Domain.Contracts;

public interface IiAssemblyTableRow : IList<IiAssemblyTableRow>
{

    IiAssemblyFactory Parent { get; }
    int Count { get; }
    IiAssemblyTableCell Item { get; }
    int Index { get; }
    string MemberName { get; }
    string DocumentName { get; set; }
    bool DocumentNameModifiable { get; }
    bool IsDocumentNameBasedOnMemberName { get; }
    IAttributeSets AttributeSets { get; }
    IEnumerator GetEnumerator();
    void Delete();
    IiAssemblyTableRow Copy(string NewMemberName);
    bool IsExcluded(object Object);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
