using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IGeneralOptions : IInjectableSingletonEntity
{

    string TextAppearance { get; set; }
    int TextSize { get; set; }
    bool ShowStartupDialog { get; set; }
    bool Show3DIndicator { get; set; }
    string UserName { get; set; }
    int UndoFileSize { get; set; }
    int ToleranceValue { get; set; }
    double SelectOtherDelay { get; set; }
    double AnnotationScale { get; set; }
    IThreadTableQuery ThreadTableQuery { get; }
    bool UseNegativeIntegralForInertialProperties { get; set; }
    bool iMateVisibility { get; set; }
    bool ShowAutocompleteForCommandAlias { get; set; }
    bool _ShowHelpDialogOnStartup { get; set; }
    bool ShowCommandPromptTooltips { get; set; }
    StartupActionTypeEnum StartupActionType { get; set; }
    StartupHelpFocusTopicEnum StartupHelpFocusTopic { get; set; }
    string StartupNewFileTemplateName { get; set; }
    string StartupProjectFileName { get; set; }
    bool EnableOptimizedSelection { get; set; }
    bool EnablePrehighlight { get; set; }
    UpdatePropertiesOnSaveForFileTypeEnum UpdatePropertiesOnSaveForFileType { get; set; }
    bool EnableLegacyProjectCreation { get; set; }
    bool ShowCommandAliasInputDialog { get; set; }
    bool EnableEnhancedHighlighting { get; set; }
    IGripSnapOptions GripSnapOptions { get; }
    double SecondLevelTooltipDelay { get; set; }
    bool ShowDocumentTabTooltips { get; set; }
    bool ShowSecondLevelTooltips { get; set; }
    bool ShowTooltips { get; set; }
    bool ShowXYZAxisLabels { get; set; }
    double TooltipDelay { get; set; }
    bool ShowVideoToolClips { get; set; }
    bool UseOblikovatiOnlineHelp { get; set; }
    bool EnableSpellCheck { get; set; }
    ISpellCheckOptions SpellCheckOptions { get; }
    bool ShowHomeBaseOnStartup { get; set; }
}
