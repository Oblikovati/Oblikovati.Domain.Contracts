namespace Oblikovati.Domain.Contracts;

public interface IPublicationTweakPaths : IList<IPublicationTweakPaths>
{

    int Count { get; }
    IPublicationTweakPath Item { get; }
    IPublicationTweakPath ItemByComponent { get; }
    IEnumerator GetEnumerator();
}
