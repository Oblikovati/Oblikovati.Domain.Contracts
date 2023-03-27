using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiPartMember
{

    IComponentDefinition Parent { get; }
    bool LinkedToFile { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; }
    bool IsEmbedded { get; }
    IReferencedFileDescriptor ReferencedFile { get; }
    IReferenceFeature PrimaryBody { get; }
    bool CustomMember { get; }
    IiPartFactory ParentFactory { get; }
    IiPartTableRow Row { get; }
    void BreakLinkToFile();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void SetEndOfPart(bool Before);
    void ChangeRow(object NewRow, object CustomInput);
    void BreakLinkToFactory();
    void SetRowName(string RowName);
}
