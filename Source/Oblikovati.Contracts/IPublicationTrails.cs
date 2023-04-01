namespace Oblikovati.Contracts;

public interface IPublicationTrails : IList<IPublicationTrails>
{
    IPublicationTrail Item { get; }
}