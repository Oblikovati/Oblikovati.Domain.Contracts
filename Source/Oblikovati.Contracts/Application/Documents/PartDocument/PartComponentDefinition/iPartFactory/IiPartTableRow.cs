using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iPartFactory;

public interface IiPartTableRow : IList<IiPartTableRow>
{
    IiPartTableCell Item { get; }
    IiPartFactory Parent { get; }
    string PartIdentifier { get; }
    string PartName { get; set; }
    int Index { get; }
    bool PartNameModifiable { get; }
    bool IsPartNameBasedOnMemberName { get; }
    string MemberName { get; }
    IAttributeSets AttributeSets { get; }

    void Delete();
    IiPartTableRow Copy(string NewMemberName);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}