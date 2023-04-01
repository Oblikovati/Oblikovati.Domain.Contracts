using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts;

public interface IiAssemblyTableRow : IList<IiAssemblyTableRow>
{
    IiAssemblyFactory Parent { get; }

    IiAssemblyTableCell Item { get; }
    int Index { get; }
    string MemberName { get; }
    string DocumentName { get; set; }
    bool DocumentNameModifiable { get; }
    bool IsDocumentNameBasedOnMemberName { get; }
    IAttributeSets AttributeSets { get; }

    void Delete();
    IiAssemblyTableRow Copy(string NewMemberName);
    bool IsExcluded(object Object);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}