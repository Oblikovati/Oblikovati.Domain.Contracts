namespace Oblikovati.Domain.Contracts;

public interface IComponentDefinitionReferences : IList<IComponentDefinitionReferences>
{
    IComponentDefinitionReference Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
