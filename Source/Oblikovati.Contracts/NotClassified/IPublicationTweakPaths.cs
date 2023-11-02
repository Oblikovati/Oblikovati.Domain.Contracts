namespace Oblikovati.Contracts.NotClassified;

public interface IPublicationTweakPaths : IList<IPublicationTweakPaths>
{
    IPublicationTweakPath Item { get; }
    IPublicationTweakPath ItemByComponent { get; }
}