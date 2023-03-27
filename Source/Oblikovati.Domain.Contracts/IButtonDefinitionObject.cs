namespace Oblikovati.Domain.Contracts;

public interface IButtonDefinitionObject : IControlDefinition
{
    bool Pressed { get; set; }
}
