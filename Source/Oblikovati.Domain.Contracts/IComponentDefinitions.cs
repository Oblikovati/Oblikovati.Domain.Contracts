namespace Oblikovati.Domain.Contracts;

public interface IComponentDefinitions : IList<IComponentDefinitions>
{
    IComponentDefinition Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
