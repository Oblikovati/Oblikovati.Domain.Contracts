using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts.Application;

public interface IApplication : IApplicationBase, IInjectableSingletonEntity
{
    IDocuments Documents { get; }
    IApplicationEvents ApplicationEvents { get; }
    IModelingEvents ModelingEvents { get; }
    ISketchEvents SketchEvents { get; }
    IStyleEvents StyleEvents { get; }
    IRepresentationEvents RepresentationEvents { get; }
    IAssemblyEvents AssemblyEvents { get; }
    IModelStateEvents ModelStateEvents { get; }
    IObjectsEnumeratorByVariant Preferences { get; }
    ITransactionManager TransactionManager { get; }
    IChangeManager ChangeManager { get; }
    string LanguageName { get; }
    IAssemblyOptions AssemblyOptions { get; }
    IGeneralOptions GeneralOptions { get; }
    ISketchOptions SketchOptions { get; }
    IPartOptions PartOptions { get; }
    ISketch3DOptions Sketch3DOptions { get; }
    IDrawingOptions DrawingOptions { get; }
    ISaveOptions SaveOptions { get; }
    IContentCenter ContentCenter { get; }
    IiFeatureOptions iFeatureOptions { get; }
    INotebookOptions NotebookOptions { get; }
    IMeasureTools MeasureTools { get; }
    ILanguageTools LanguageTools { get; }
    bool Ready { get; }
    IUnitsOfMeasure UnitsOfMeasure { get; }
    ITransientBRep TransientBRep { get; }
    bool SupportsFileManagement { get; set; }
    IErrorManager ErrorManager { get; }
    IContentCenterOptions ContentCenterOptions { get; }
    IStylesManager StylesManager { get; }
    IPresentationOptions PresentationOptions { get; }
    IAssetLibrary ActiveAppearanceLibrary { get; set; }
    IAssetLibrary ActiveMaterialLibrary { get; set; }
    IAssetLibraries AssetLibraries { get; }
    IAssetsEnumerator FavoriteAssets { get; }
    MaterialDisplayUnitsEnum MaterialDisplayUnits { get; set; }
    IColorScheme ActiveColorScheme { get; }
    IColorSchemes ColorSchemes { get; }
    IiLogicOptions iLogicOptions { get; }
    ICustomDataEvents _CustomDataEvents { get; }
    bool _LibraryDocumentModifiable { get; set; }
    IDocument ActiveDocument { get; }
    IDocument ActiveEditDocument { get; }
    DocumentTypeEnum ActiveDocumentType { get; }
    IView ActiveView { get; }
    IViewsEnumerator Views { get; }
    string Caption { get; set; }
    bool Visible { get; set; }
    bool IsCIPEnabled { get; }
    string ADPSessionId { get; }
    string ADPDeviceId { get; }
    ICommandManager CommandManager { get; }
    bool MRUEnabled { get; set; }
    bool MRUDisplay { get; set; }
    bool SilentOperation { get; set; }
    object ActiveEditObject { get; }
    string StatusBarText { get; set; }
    IEnvironments Environments { get; }
    IEnvironmentBaseCollection EnvironmentBaseCollection { get; }
    IEnvironment ActiveEnvironment { get; }
    int Top { get; set; }
    int Left { get; set; }
    int Height { get; set; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    bool ScreenUpdating { get; set; }
    IUserInterfaceManager UserInterfaceManager { get; }
    IThemeManager ThemeManager { get; }
    IFileUIEvents FileUIEvents { get; }
    ICameraEvents CameraEvents { get; }
    bool FlythroughMode3Dx { get; set; }
    bool CameraRollMode3Dx { get; set; }
    bool OpenDocumentsDisplay { get; set; }
    string LanguageCode { get; }
    ITutorialsManager TutorialsManager { get; }
    IWebViews WebViews { get; }
    IWebView ActiveWebView { get; }
    IWebBrowserDialogs WebBrowserDialogs { get; }
    bool IsIn3dPrintMode { get; }
    bool AllowDataCollectionForAnalyticsPrograms { get; }
    List<string> AvailableComparisonVersions { get; }
    string ComparisonVersion { get; set; }
    IViewFrame ActiveViewFrame { get; }
    IViewFramesEnumerator ViewFrames { get; }
    IClientResourceMaps ClientResourceMaps { get; }
    void WriteCIPWaypoint(string WaypointData);
    void Move(int Top, int Left, int Height, int Width);
    void CreateFileDialog(out IFileDialog Dialog);
    IProgressBar CreateProgressBar(bool DisplayInStatusBar, int NumberOfSteps, string Title, bool AllowCancel, int HWND);
    bool Login();
    void ShowMyHomeWindow(object ContentTypeOrURL);
    StatusEnum GetSubscriptionEnablerStatus(string VersionNumber);
    IFactoryTableDialog CreateFactoryTableDialog(string FullFileName);
    void RefreshRibbonForComparison();
    void ExportApplicationOptions(string FullFileName);
    void ImportApplicationOptions(string FullFileName);
    void UseAutoCADRelatedSettings();
    void UseOblikovatiSettings();
    string GetTemplateFile(DocumentTypeEnum DocumentType, SystemOfMeasureEnum SystemOfMeasure, DraftingStandardEnum DraftingStandard, object DocumentSubType);
    void _ConstructInternalNameAndFileVersion(string Name, string Number, string Custom, string Revision, out string InternalName, out string FileVersion);
    void CreateInternalName(string Name, string Number, string Custom, out string InternalName);
    object GetInterfaceObject(string ProgIDorCLSID);
    object GetInterfaceObject32(string ProgIDorCLSID);
    void ConstructInternalNameAndRevisionId(string InternalNameToken, string RevisionIdToken, out string InternalName, out string RevisionId);
    void _ReplayTranscript(string TranscriptFileName);
    void _MigrateStylesLibrary(string LibraryPath, out string Result, out int NumLibraries);
    void _LogExceptionDump(int Value);
    void _GetShapeManagerVersion(out int MajorVersion, out int MinorVersion, out int PointVersion);
    bool _CanMigrateCustomSettings(CustomSettingsTypeEnum CustomSettingsType, string FromBuildIdentifier);
    bool _MigrateCustomSettings(CustomSettingsTypeEnum CustomSettingsType, string FromBuildIdentifier);
    void GetAppFrameExtents(out int Top, out int Left, out int Height, out int Width);
    void GetMDIClientAreaExtents(out int Top, out int Left, out int Height, out int Width);

}
