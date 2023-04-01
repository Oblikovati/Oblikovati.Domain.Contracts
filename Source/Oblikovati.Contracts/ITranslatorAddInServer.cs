using Oblikovati.Contracts.Application.ApplicationAddIns;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface ITranslatorAddInServer
{
    object Automation { get; }
    bool HasOpenOptions { get; }
    bool HasSaveCopyAsOptions { get; }
    void Activate(IApplicationAddInSite AddInSite, bool FirstTime);
    void Deactivate();
    void ExecuteCommand(int CommandID);
    void ShowOpenOptions(IDataMedium SourceData, ITranslationContext Context, INameValueMap ChosenOptions);
    void Open(IDataMedium SourceData, ITranslationContext Context, INameValueMap Options, ref object TargetObject);
    void ShowSaveCopyAsOptions(object Source, ITranslationContext Context, INameValueMap ChosenOptions);
    void SaveCopyAs(object Source, ITranslationContext Context, INameValueMap Options, IDataMedium TargetData);
    object GetThumbnail(IDataMedium SourceData);
}