namespace Oblikovati.Domain.Contracts;

public interface IDerivedAliasComponents : IList<IDerivedAliasComponents>
{

    int Count { get; }
    IDerivedAliasComponent Item { get; }
    IComponentDefinition Parent { get; }
    IEnumerator GetEnumerator();
}
