using Oblikovati.Contracts.Application.FileManager;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface IDocumentDescriptor
{
    string DisplayName { get; }
    string FullDocumentName { get; }
    LevelOfDetailEnum ReferencedLevelOfDetail { get; }
    object ReferencedDocument { get; }
    DocumentType ReferencedDocumentType { get; }
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