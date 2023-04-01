namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IButtonDefinitionHandlerObject
{
    IControlDefinition ControlDefinition { get; }
    bool Enabled { get; set; }
    bool Pressed { get; set; }
}