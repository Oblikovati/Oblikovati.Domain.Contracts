namespace Oblikovati.Domain.Contracts;

public interface IiFeatureComponents : IList<IiFeatureComponents>
{

    int Count { get; }
    IiFeatureComponent Item { get; }
    IComponentDefinition Parent { get; }
    IiFeatureComponent Add(IiFeatureDefinition Definition);
    IiFeatureDefinition CreateDefinition(string FullFileName);
    IEnumerator GetEnumerator();
}
