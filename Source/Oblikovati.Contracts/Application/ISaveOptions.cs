using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application;

public interface ISaveOptions : IInjectableSingletonEntity
{
    bool PromptSaveForRecomputableChanges { get; set; }
    bool PromptSaveForMigration { get; set; }
    bool DefaultToSaveForMigration { get; set; }
    bool PromptSaveForUserEdits { get; set; }
    bool DefaultToSaveForUserEdits { get; set; }
    bool PromptSaveForAPIChanges { get; set; }
    bool DefaultToSaveForAPIChanges { get; set; }
    bool PromptSaveForManualUpdates { get; set; }
    bool DefaultToSaveForManualUpdates { get; set; }
    bool PromptSaveForFileResolutionChange { get; set; }
    bool DefaultToSaveForFileResolutionChange { get; set; }
    bool PromptSaveForMassPropertyUpdate { get; set; }
    bool DefaultToSaveForMassPropertyUpdate { get; set; }
    bool PromptSaveForImplicitUpdate { get; set; }
    bool DefaultToSaveForImplicitUpdate { get; set; }
    bool SaveFilesInLibraryFolders { get; set; }
    bool ListReferencedFilesInSaveDialog { get; set; }
    double SaveReminderTimer { get; set; }
    bool ShowSaveReminder { get; set; }
    ReportLocationEnum TranslatorReportLocation { get; set; }
    bool PromptSaveForModelStateUpdates { get; set; }
    bool DefaultToSaveForModelStateUpdates { get; set; }
}