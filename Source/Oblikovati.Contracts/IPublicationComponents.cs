namespace Oblikovati.Contracts;

public interface IPublicationComponents : IList<IPublicationComponents>
{
    IPublicationComponent Item { get; }

    IPublicationComponent Add(string FullDocumentName, bool IsAnyCAD, object Position, object FactoryTableRow,
        object CustomMemberDestination, object CustomInput, object Options);

    bool HasRootComponent();
}