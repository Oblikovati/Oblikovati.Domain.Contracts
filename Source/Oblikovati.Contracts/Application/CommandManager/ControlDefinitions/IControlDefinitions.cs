using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IControlDefinitions : IDictionary<string, IControlDefinition>, IInjectableSingletonEntity
{
    bool UseDefaultMultiCharAliases { get; set; }

    IButtonDefinition AddButtonDefinition(string DisplayName, string InternalName, CommandTypesEnum Classification,
        Guid ClientId, string DescriptionText, string ToolTipText, object StandardIcon, object LargeIcon,
        ButtonDisplayEnum ButtonDisplay);

    IComboBoxDefinition AddComboBoxDefinition(string DisplayName, string InternalName, CommandTypesEnum Classification,
        int DropDownWidth, Guid ClientId, string DescriptionText, string ToolTipText, object StandardIcon,
        object LargeIcon, ButtonDisplayEnum ButtonDisplay);

    IMacroControlDefinition AddMacroControlDefinition(string MacroOrProgram);
}