namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IProgressiveToolTip
{
    IControlDefinition Parent { get; }
    string Description { get; set; }
    string ExpandedDescription { get; set; }
    object Image { get; set; }
    bool IsProgressive { get; set; }
    string Title { get; set; }
    string Video { get; set; }
}