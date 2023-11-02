namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationTrails : IList<IPublicationTrails>
{
    IPublicationTrail Item { get; }
}