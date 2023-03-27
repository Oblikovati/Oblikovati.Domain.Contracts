namespace Oblikovati.Domain.Contracts;

public interface IDerivedFuturePartComponents : IList<IDerivedFuturePartComponents>
{

    int Count { get; }
    IDerivedFuturePartComponent Item { get; }
    IComponentDefinition Parent { get; }
    IDerivedFuturePartComponent Add(IDerivedFuturePartDefinition Definition);
    IDerivedFuturePartDefinition CreateDefinition(string FullDocumentName);
    IEnumerator GetEnumerator();
}
