namespace Oblikovati.Domain.Contracts;

public interface IPublicationComponents : IList<IPublicationComponents>
{

    int Count { get; }
    IPublicationComponent Item { get; }
    IEnumerator GetEnumerator();
    IPublicationComponent Add(string FullDocumentName, bool IsAnyCAD, object Position, object FactoryTableRow, object CustomMemberDestination, object CustomInput, object Options);
    bool HasRootComponent();
}
