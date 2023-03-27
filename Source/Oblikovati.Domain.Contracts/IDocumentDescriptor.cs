using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDocumentDescriptor
{


    string DisplayName { get; }
    string FullDocumentName { get; }
    LevelOfDetailEnum ReferencedLevelOfDetail { get; }
    object ReferencedDocument { get; }
    DocumentTypeEnum ReferencedDocumentType { get; }
    IFileDescriptor ReferencedFileDescriptor { get; }
    bool ReferenceMissing { get; }
    bool ReferenceReplaced { get; }
    bool ReferenceSuppressed { get; }
    bool ReferenceDisabled { get; }
    FileOwnershipEnum OwnershipType { get; set; }
    bool ReferenceInternalNameDifferent { get; }
    bool ReferenceLocationDifferent { get; }
    ModelStateTypeEnum ReferencedModelState { get; }
}
