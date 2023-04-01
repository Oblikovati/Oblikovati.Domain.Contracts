namespace Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

public interface IComponentDefinitionReferences : IList<IComponentDefinitionReferences>
{
    IComponentDefinitionReference Item { get; }
}