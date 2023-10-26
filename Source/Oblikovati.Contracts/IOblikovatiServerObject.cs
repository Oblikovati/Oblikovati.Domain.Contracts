using Oblikovati.Contracts.Application;
using Oblikovati.Contracts.Application.ApplicationAddIns;
using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.ChangeManager;
using Oblikovati.Contracts.Application.ColorSchemes;
using Oblikovati.Contracts.Application.ContentCenter;
using Oblikovati.Contracts.Application.DesignProjectManager;
using Oblikovati.Contracts.Application.DisplayOptions;
using Oblikovati.Contracts.Application.Documents;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.ErrorManager;
using Oblikovati.Contracts.Application.FileManager;
using Oblikovati.Contracts.Application.GeneralOptions;
using Oblikovati.Contracts.Application.TransactionManager;
using Oblikovati.Contracts.Application.TransientBRep;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Unsorted;

namespace Oblikovati.Contracts;

public interface IOblikovatiServerObject
{
    IDocuments Documents { get; }
    ISoftwareVersion SoftwareVersion { get; }
    IApplicationEvents ApplicationEvents { get; }
    IModelingEvents ModelingEvents { get; }
    ISketchEvents SketchEvents { get; }
    IStyleEvents StyleEvents { get; }
    IRepresentationEvents RepresentationEvents { get; }
    IAssemblyEvents AssemblyEvents { get; }
    IPublicationEvents _PublicationEvents { get; }
    IFileAccessEvents FileAccessEvents { get; }
    IModelStateEvents ModelStateEvents { get; }
    IObjectsEnumeratorByVariant Preferences { get; }
    IApplicationAddIns ApplicationAddIns { get; }
    IFileLocations FileLocations { get; }
    ITransactionManager TransactionManager { get; }
    IChangeManager ChangeManager { get; }
    int Locale { get; }
    string LanguageName { get; }
    ITransientGeometry TransientGeometry { get; }
    ITransientObjects TransientObjects { get; }
    string UserName { get; set; }
    IFileManager FileManager { get; }
    IAssemblyOptions AssemblyOptions { get; }
    IGeneralOptions GeneralOptions { get; }
    ISketchOptions SketchOptions { get; }
    IPartOptions PartOptions { get; }
    ISketch3DOptions Sketch3DOptions { get; }
    IDrawingOptions DrawingOptions { get; }
    ISaveOptions SaveOptions { get; }
    IFileOptions FileOptions { get; }
    IHardwareOptions HardwareOptions { get; }
    IContentCenter ContentCenter { get; }
    IiFeatureOptions iFeatureOptions { get; }
    INotebookOptions NotebookOptions { get; }
    IDisplayOptions DisplayOptions { get; }
    IMeasureTools MeasureTools { get; }
    string InstallPath { get; }
    string CurrentUserAppDataPath { get; }
    string AllUsersAppDataPath { get; }
    ILanguageTools LanguageTools { get; }
    bool Ready { get; }
    IUnitsOfMeasure UnitsOfMeasure { get; }
    ITransientBRep TransientBRep { get; }
    bool SupportsFileManagement { get; set; }
    IErrorManager ErrorManager { get; }
    IContentCenterOptions ContentCenterOptions { get; }
    IStylesManager StylesManager { get; }
    bool _IsRegistryEntry { get; }
    object _RegistryEntry { get; }
    bool _CanReplayTranscript { get; }
    bool _TranscriptAPIChanges { get; set; }
    IDebugInstrumentation _DebugInstrumentation { get; }
    object _TestIO { get; set; }
    I_AppPerformanceMonitor _AppPerformanceMonitor { get; }
    bool _ForceMigrationOnOpen { get; set; }
    bool _UpdateAnnotationsOnSheetActivate { set; }
    bool _HarvestStylesOnOpen { get; set; }
    bool _PurgeStylesOnOpen { get; set; }
    ITestManager TestManager { get; }
    IDesignProjectManager DesignProjectManager { get; }
    IPresentationOptions PresentationOptions { get; }
    IAssetLibrary ActiveAppearanceLibrary { get; set; }
    IAssetLibrary ActiveMaterialLibrary { get; set; }
    IAssetLibraries AssetLibraries { get; }
    IAssetsEnumerator FavoriteAssets { get; }
    MaterialDisplayUnitsEnum MaterialDisplayUnits { get; set; }
    IColorScheme ActiveColorScheme { get; }
    IColorSchemes ColorSchemes { get; }
    IiLogicOptions iLogicOptions { get; }
    bool _SuppressFileDirtyEvents { get; set; }
    string _TranscriptFileName { get; }
    IReferenceKeyEvents ReferenceKeyEvents { get; }
    string _DefaultPrinter3DName { get; set; }
    bool _IsFileVersionSupported { get; }
    bool _IsReplayingTranscript { get; }
    bool _IsOblikovatiFile { get; }
    bool _DefaultDocType { get; }
    bool _IsTranscriptingOn { get; set; }
    bool _LibraryDocumentModifiable { get; set; }

    string GetTemplateFile(DocumentType DocumentType, SystemOfMeasureEnum SystemOfMeasure,
        DraftingStandardEnum DraftingStandard, object DocumentSubType);

    void _ConstructInternalNameAndFileVersion(string Name, string Number, string Custom, string Revision,
        out string InternalName, out string FileVersion);

    void CreateInternalName(string Name, string Number, string Custom, out string InternalName);
    object GetInterfaceObject(string ProgIDorCLSID);
    object GetInterfaceObject32(string ProgIDorCLSID);

    void ConstructInternalNameAndRevisionId(string InternalNameToken, string RevisionIdToken, out string InternalName,
        out string RevisionId);

    void ReserveLicense(string ClientId);
    void UnreserveLicense(string ClientId);

    void _SetRegistryEntry(string SubKey, string ValueName, object Value, _RegistryHiveTypeEnum RegistryHive,
        bool RefreshWithEntry);

    void _DeleteRegistryEntry(string SubKey, string ValueName, _RegistryHiveTypeEnum RegistryHive);
    void _ReplayTranscript(string TranscriptFileName);
    void _MigrateStylesLibrary(string LibraryPath, out string Result, out int NumLibraries);
    void _LogExceptionDump(int Value);
    void _GetShapeManagerVersion(out int MajorVersion, out int MinorVersion, out int PointVersion);
    string LicenseChallenge();
    void LicenseResponse(string Response);
    bool _CanMigrateCustomSettings(CustomSettingsTypeEnum CustomSettingsType, string FromBuildIdentifier);
    bool _MigrateCustomSettings(CustomSettingsTypeEnum CustomSettingsType, string FromBuildIdentifier);
}