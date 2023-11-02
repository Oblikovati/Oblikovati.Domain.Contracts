namespace Oblikovati.Contracts.NotClassified;

public interface IStoryboard
{
    IPublication Parent { get; }
    IPublicationTweaks Tweaks { get; }
    int Id { get; }
    IPublicationTrails Trails { get; }
    void Delete();
}