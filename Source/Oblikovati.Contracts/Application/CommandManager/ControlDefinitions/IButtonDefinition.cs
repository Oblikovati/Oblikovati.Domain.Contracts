namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IButtonDefinition : IControlDefinition
{
    bool Pressed { get; set; }
    EventHandler? OnExecute { get; set; }
    EventHandler? OnHelp {  get; set; }
}