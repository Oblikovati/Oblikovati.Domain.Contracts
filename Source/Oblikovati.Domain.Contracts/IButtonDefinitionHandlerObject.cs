namespace Oblikovati.Domain.Contracts;

public interface IButtonDefinitionHandlerObject
{
    IControlDefinition ControlDefinition { get; }
    bool Enabled { get; set; }
    bool Pressed { get; set; }
}
