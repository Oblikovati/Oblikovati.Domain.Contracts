using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IControlDefinitions : IList<IControlDefinition>
{
    public IControlDefinition this[string Index] { get; }
    bool UseDefaultMultiCharAliases { get; set; }
    IButtonDefinition AddButtonDefinition(string DisplayName, string InternalName, CommandTypesEnum Classification, string ClientId, string DescriptionText, string ToolTipText, object StandardIcon, object LargeIcon, ButtonDisplayEnum ButtonDisplay);
    IComboBoxDefinition AddComboBoxDefinition(string DisplayName, string InternalName, CommandTypesEnum Classification, int DropDownWidth, string ClientId, string DescriptionText, string ToolTipText, object StandardIcon, object LargeIcon, ButtonDisplayEnum ButtonDisplay);
    IMacroControlDefinition AddMacroControlDefinition(string MacroOrProgram);
}
