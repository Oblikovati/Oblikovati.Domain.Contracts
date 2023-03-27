namespace Oblikovati.Domain.Contracts;

public interface IPublicationMarkedViews : IList<IPublicationMarkedViews>
{

    int Count { get; }
    IPublicationMarkedView Item { get; }
    IPublicationMarkedView ItemById { get; }
    IEnumerator GetEnumerator();
    IPublicationMarkedView Add(object DisplayName);
}
