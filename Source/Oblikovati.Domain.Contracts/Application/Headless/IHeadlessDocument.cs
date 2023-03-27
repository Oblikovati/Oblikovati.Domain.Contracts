using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Application.Headless;

public interface IHeadlessDocument
{
    DocumentTypeEnum DocumentType { get; }
    IComponentDefinitions ComponentDefinitions { get; }
    IComponentDefinition ComponentDefinition { get; }
    string FullFileName { get; }
    string DisplayName { get; set; }
    int FileSaveCounter { get; }
    ISoftwareVersion SoftwareVersionCreated { get; }
    ISoftwareVersion SoftwareVersionSaved { get; }
    bool NeedsMigrating { get; }
    bool Dirty { get; set; }
    bool Compacted { get; }
    bool ReservedForWrite { get; }
    bool ReservedForWriteByMe { get; set; }
    string ReservedForWriteName { get; }
    string ReservedForWriteLogin { get; }
    int ReservedForWriteVersion { get; }
    DateTime ReservedForWriteTime { get; }
    bool IsModifiable { get; }
    HealthStatusEnum HealthStatus { get; }
    IReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    IReferencedOpaqueFileDescriptors ReferencedOpaqueFileDescriptors { get; }
    IPropertySets PropertySets { get; }
    string InternalName { get; }
    string RevisionId { get; }
    string DatabaseRevisionId { get; }
    IAttributeManager AttributeManager { get; }
    IUnitsOfMeasure UnitsOfMeasure { get; }
    IRenderStyle ActiveRenderStyle { get; }
    IClientViews ClientViews { get; }
    IHeadlessPrintManager PrintManager { get; }
    IDocumentDescriptorsEnumerator ReferencedDocumentDescriptors { get; }
    IFile File { get; }
    string FullDocumentName { get; }
    bool Open { get; }
    IHeadlessDocuments ReferencedDocuments { get; }
    IHeadlessDocuments ReferencingDocuments { get; }
    IHeadlessDocuments AllReferencedDocuments { get; }
    IDocumentInterests DocumentInterests { get; }
    bool IsSubstitutePart { get; }
    ReferenceStatusEnum SubstitutePartStatus { get; }
    IReferenceKeyManager ReferenceKeyManager { get; }
    IAttributeSets AttributeSets { get; }
    bool RequiresUpdate { get; }
    I_DocPerformanceMonitor _DocPerformanceMonitor { get; }
    string RedirectionInfo { get; set; }
    IHeadlessDocuments ReferencedFiles { get; }
    IHeadlessDocuments AllReferencedFiles { get; }
    IReferencedFileDescriptors ReferencedFileDescriptors { get; }
    IHighlightSets HighlightSets { get; }
    void GetLocationFoundIn(out string LocationName, out LocationTypeEnum Type);
    void RevertReservedForWriteByMe();
    IHeadlessDocuments FindWhereUsed(string FullFileName);
    IHighlightSet CreateHighlightSet();
    void Close();
    void _GetReferenceInfo(out string DatabaseRevisionId, out string LastSavedLocation, out object Indices, out object OldPaths, out object CurrentPaths, bool SkipUnreferenced);
    void _GetForeignFileReferenceInfo(out object Indices, out object CurrentPaths);
}
