using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ITranslatorAddIn
{
    string ClassIdString { get; }
    string ProgId { get; }
    string DisplayName { get; }
    string ShortDisplayName { get; }
    string Description { get; }
    bool StartUpEnabled { get; set; }
    int Version { get; }
    bool Hidden { get; set; }
    bool UserUnloadable { get; set; }
    ApplicationAddInTypeEnum AddInType { get; }
    bool Activated { get; }
    object Automation { get; }
    int DataVersion { get; set; }
    string ClientId { get; }


    string Location { get; }
    int UserInterfaceVersion { get; }
    AddInLoadBehaviorEnum LoadBehavior { get; }
    bool LoadAutomatically { get; set; }
    bool SupportsOpen { get; }
    bool SupportsSaveCopyAs { get; }
    string FileExtensions { get; }
    string FilterText { get; }
    bool HasOpenOptions { get; }
    bool HasSaveCopyAsOptions { get; }
    bool TranslatorAvailable { get; set; }
    string SupportsImportInto { get; }
    string SupportsOpenInto { get; }
    string SupportsSaveCopyAsFrom { get; }
    void Activate();
    void Deactivate();
    void DocumentTypesSupported(ref List<int> DocumentTypes);
    void ShowOpenOptions(IDataMedium SourceData, ITranslationContext Context, INameValueMap ChosenOptions);
    void Open(IDataMedium SourceData, ITranslationContext Context, INameValueMap Options, out object TargetObject);
    void ShowSaveCopyAsOptions(object Source, ITranslationContext Context, INameValueMap ChosenOptions);
    void SaveCopyAs(object Source, ITranslationContext Context, INameValueMap Options, IDataMedium TargetData);
    object GetThumbnail(IDataMedium SourceData);
}