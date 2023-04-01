namespace Oblikovati.Contracts.Application.CommandManager.ControlDefinitions;

public interface IButtonDefinitionObject : IControlDefinition
{
    bool Pressed { get; set; }
}