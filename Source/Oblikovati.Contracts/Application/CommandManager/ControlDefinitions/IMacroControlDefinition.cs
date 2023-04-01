using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IMacroControlDefinition
{
    string InternalName { get; }
    string DisplayName { get; }
    bool BuiltIn { get; }
    CommandTypesEnum Classification { get; }
    ICommandManager Parent { get; }
    ControlDefinitionTypeEnum DefinitionType { get; }
    string DescriptionText { get; set; }
    bool Enabled { get; set; }
    int Id { get; }
    string ToolTipText { get; set; }
    IControlDefinitionEvents ControlDefinitionEvents { get; }
    string ClientId { get; }
    string DefaultShortcut { get; set; }
    ShortcutTypeEnum DefaultShortcutType { get; }
    bool IsShortcutOverridden { get; }
    string OverrideShortcut { get; set; }
    ShortcutTypeEnum OverrideShortcutType { get; }
    IProgressiveToolTip ProgressiveToolTip { get; }
    string IntroducedInVersion { get; set; }
    string LastUpdatedVersion { get; set; }
    string MacroOrFileName { get; }
    void Delete();
    void AutoAddToGUI();
    void Execute();
    void Execute2(bool Synchronous);
}