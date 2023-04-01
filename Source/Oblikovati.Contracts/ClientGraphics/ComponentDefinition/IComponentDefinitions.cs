namespace Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

public interface IComponentDefinitions : IList<IComponentDefinitions>
{
    IComponentDefinition Item { get; }
}