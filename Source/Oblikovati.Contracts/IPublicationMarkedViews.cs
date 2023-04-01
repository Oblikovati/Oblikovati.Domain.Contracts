namespace Oblikovati.Contracts;

public interface IPublicationMarkedViews : IList<IPublicationMarkedViews>
{
    IPublicationMarkedView Item { get; }
    IPublicationMarkedView ItemById { get; }

    IPublicationMarkedView Add(object DisplayName);
}