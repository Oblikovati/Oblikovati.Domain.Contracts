namespace Oblikovati.Domain.Contracts;

public interface IFileDialog
{
    bool CancelError { get; set; }
    string DialogTitle { get; set; }
    string FileName { get; set; }
    string Filter { get; set; }
    int FilterIndex { get; set; }
    string InitialDirectory { get; set; }
    bool SuppressResolutionWarnings { get; set; }
    bool OptionsEnabled { get; set; }
    IFileDialogEvents FileDialogEvents { get; }
    bool MultiSelectEnabled { get; set; }
    bool InsertMode { get; set; }
    INameValueMap OptionValues { get; }
    bool ShowQuickLaunch { get; set; }
    bool EnableSkipAllUnresolvedFilesOption { get; set; }
    bool EnableLODRepresentationOption { get; set; }
    bool DesignViewAssociative { get; set; }
    bool ShowExistingDesignViewsOnlyInDropdown { get; set; }
    bool ShowExistingLevelOfDetailsOnlyInDropdown { get; set; }
    void ShowSave();
    void ShowOpen();
    void SetHelpContext(string FileName, int Context);
    void SetHelpTopic(string FileName, string TopicName);
}
