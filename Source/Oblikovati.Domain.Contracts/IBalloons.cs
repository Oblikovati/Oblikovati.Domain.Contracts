namespace Oblikovati.Domain.Contracts;

public interface IBalloons : IList<IBalloons>
{

    IBalloon Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBalloon Add(IObjectCollection LeaderPoints, object VirtualComponent, object Level, object NumberingScheme, object BalloonStyle, object Layer);
}
