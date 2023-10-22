using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.Document.AttributeManager;
using Oblikovati.Contracts.Application.Documents.Document.BrowserPanes;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Application.FileManager;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.Environments;
using Oblikovati.Contracts.Application.Views;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics;
using Oblikovati.Contracts.ClientGraphics.DrawingView;
using Oblikovati.Contracts.DWG;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.GraphicsDataSets;
using Oblikovati.Contracts.Parameters;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Unsorted;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument;

public interface IDrawingDocument
{
    DocumentType DocumentType { get; }
    string DisplayName { get; set; }
    bool DisplayNameOverridden { get; set; }
    IFile File { get; }
    string FullDocumentName { get; }
    bool Open { get; }
    IDocumentDescriptorsEnumerator ReferencedDocumentDescriptors { get; }
    IDocumentsEnumerator ReferencedDocuments { get; }
    IDocumentsEnumerator ReferencingDocuments { get; }
    IDocumentsEnumerator AllReferencedDocuments { get; }
    string FullFileName { get; set; }
    IViews Views { get; }
    IClientViews ClientViews { get; }
    bool Dirty { get; set; }
    bool Compacted { get; }
    IDocumentEvents DocumentEvents { get; }
    CommandType _DefaultCommand { get; }
    string DefaultCommand { get; }
    IReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    IObjectsEnumerator ReferencedOLEFileDescriptors2 { get; }
    IReferencedOpaqueFileDescriptors ReferencedOpaqueFileDescriptors { get; }
    int FileSaveCounter { get; }
    ISoftwareVersion SoftwareVersionCreated { get; }
    ISoftwareVersion SoftwareVersionSaved { get; }
    bool ReservedForWrite { get; }
    bool ReservedForWriteByMe { get; set; }
    string ReservedForWriteName { get; }
    string ReservedForWriteLogin { get; }
    int ReservedForWriteVersion { get; }
    DateTime ReservedForWriteTime { get; }
    bool IsModifiable { get; }
    IPropertySets PropertySets { get; }
    IAttributeManager AttributeManager { get; }
    string InternalName { get; }
    string RevisionId { get; }
    string DatabaseRevisionId { get; }
    string SubType { get; set; }
    IUnitsOfMeasure UnitsOfMeasure { get; }
    bool RequiresUpdate { get; }
    object ActivatedObject { get; }
    IPrintManager PrintManager { get; }
    IGraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    IRenderStyles RenderStyles { get; }
    IBrowserPanes BrowserPanes { get; }
    IReferenceKeyManager ReferenceKeyManager { get; }
    ISelectSet SelectSet { get; }
    ISelectionPreferences SelectionPreferences { get; }
    CommandTypesEnum DisabledCommandTypes { get; set; }
    IDocumentSubType DocumentSubType { get; }
    CommandTypesEnum RecentChanges { get; }
    SelectionPriorityEnum SelectionPriority { get; set; }
    IDocumentInterests DocumentInterests { get; }
    bool NeedsMigrating { get; }
    ThumbnailSaveOptionEnum ThumbnailSaveOption { get; }
    IAttributeSets AttributeSets { get; }
    int _SickNodesCount { get; }
    int _ComatoseNodesCount { get; }
    string _PrimaryDeselGUID { get; }
    bool _IsTemplateUsed { get; }
    I_DocPerformanceMonitor _DocPerformanceMonitor { get; }
    FileOwnershipEnum OwnershipType { get; }
    IDocument OblikovatiDocument { get; }
    IDocumentsEnumerator ReferencedFiles { get; }
    IReferencedFileDescriptors ReferencedFileDescriptors { get; }
    IHighlightSets HighlightSets { get; }
    string _InternalName { get; }
    IGraphicsDataSetsCollection NonTransactingGraphicsDataSetsCollection { get; }
    IClientGraphicsCollection NonTransactingClientGraphicsCollection { get; }
    string ModelStateName { get; }
    IModelState _MigrateLODToModelState { get; }
    IPropertySets FilePropertySets { get; }
    ISheet ActiveSheet { get; }
    ISheets Sheets { get; }
    ITextStyles _TextStyles { get; }
    IBorderDefinitions BorderDefinitions { get; }
    ITitleBlockDefinitions TitleBlockDefinitions { get; }
    ISketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
    IDrawingSettings DrawingSettings { get; }
    ISketchSettings SketchSettings { get; }
    IDrawingStylesManager StylesManager { get; }
    IDrawingEvents DrawingEvents { get; }
    IDisabledCommandList DisabledCommandList { get; }
    IEnvironmentManager EnvironmentManager { get; }
    ISheetSettings SheetSettings { get; }
    object ContainingDWGDocument { get; }
    bool IsOblikovatiDWG { get; }
    ISheetFormats SheetFormats { get; }
    IDrawingBOMs DrawingBOMs { get; }
    IAutoCADBlockDefinitions AutoCADBlockDefinitions { get; }
    IParameters Parameters { get; }
    IDrawingHatchPatternsManager DrawingHatchPatternsManager { get; }
    void SaveAsOblikovatiDWG(string FullFileName, bool SaveCopyAs);
    void MakeAllViewsRaster();
    void MakeAllViewsPrecise();
    void GetLocationFoundIn(out string LocationName, out LocationTypeEnum LocationType);
    void Activate();
    void Close(bool SkipSave);
    void Save();
    void Save2(bool SaveDependents, object DocumentsToSave);
    void SaveAs(string FileName, bool SaveCopyAs);
    void SaveAsWithOptions(string FileName, INameValueMap Options);
    bool HasPrivateStorage(string StorageName);
    bool HasPrivateStream(string StreamName);
    object GetPrivateStorage(string StorageName, bool CreateIfNecessary);
    object GetPrivateStream(string StreamName, bool CreateIfNecessary);
    IDocumentsEnumerator FindWhereUsed(string FullFileName);
    void RevertReservedForWriteByMe();

    void PutInternalNameAndRevisionId(string InternalNameToken, string RevisionIdToken, out string InternalName,
        out string RevisionId);

    void Update();
    bool Update2(bool AcceptErrorsAndContinue);
    void Rebuild();
    bool Rebuild2(bool AcceptErrorsAndContinue);
    void SetMissingAddInBehavior(string ClientId, CommandTypesEnum DisabledCommandTypesEnum, object DisabledCommands);

    void GetMissingAddInBehavior(out string ClientId, out CommandTypesEnum DisabledCommandTypesEnum,
        out IObjectCollection DisabledCommands);

    IHighlightSet CreateHighlightSet();
    void Migrate();
    void ReleaseReference();
    void SetThumbnailSaveOption(ThumbnailSaveOptionEnum SaveOption, string ImageFullFileName);
    void _XmlOutToFile(string schemaXmlString, string outXmlFile);
    void LockSaveSet();
    void PutInternalName(string Name, string Number, string Custom, out string InternalName);

    void _PutInternalNameAndFileVersion(string Name, string Number, string Custom, string Revision,
        out string InternalName, out string FileVersion);

    void _DeleteUnusedEmbeddings(bool Preview, out int NumEmbeddings, ref List<string> Embeddings);
    void ProcessViewSelection(IGenericObject Selection, out IDrawingView ContainingView, out object SelectedObject);
}