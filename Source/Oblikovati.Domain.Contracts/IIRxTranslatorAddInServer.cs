namespace Oblikovati.Domain.Contracts;

public interface IIRxTranslatorAddInServer : IIRxApplicationAddInServer
{
    object Automation { get; }
    short HasOpenOptions { get; }
    short HasSaveCopyAsOptions { get; }
    void Activate(IIRxApplicationAddInSite pAddInSite, short FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
    void ShowOpenOptions(IDataMedium SourceData, ITranslationContext Context, INameValueMap ChosenOptions);
    void Open(IDataMedium SourceData, ITranslationContext Context, INameValueMap Options, out object TargetObject);
    void ShowSaveCopyAsOptions(object Source, ITranslationContext Context, INameValueMap ChosenOptions);
    void SaveCopyAs(object Source, ITranslationContext Context, INameValueMap Options, IDataMedium TargetData);
}
