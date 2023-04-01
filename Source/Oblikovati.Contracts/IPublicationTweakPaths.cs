namespace Oblikovati.Contracts;

public interface IPublicationTweakPaths : IList<IPublicationTweakPaths>
{
    IPublicationTweakPath Item { get; }
    IPublicationTweakPath ItemByComponent { get; }
}