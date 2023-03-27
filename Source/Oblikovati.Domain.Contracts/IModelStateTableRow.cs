namespace Oblikovati.Domain.Contracts;

public interface IModelStateTableRow : IList<IModelStateTableRow>
{

    IAttributeSets AttributeSets { get; }
    int Index { get; }
    IModelStateTable Parent { get; }
    string MemberName { get; }
    int Count { get; }
    IModelStateTableCell Item { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    IModelStateTableRow Copy(string NewName);
    IEnumerator GetEnumerator();
}
