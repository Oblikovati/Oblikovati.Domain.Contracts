namespace Oblikovati.Domain.Contracts;

public interface IBalloonTips : IList<IBalloonTips>
{
    int Count { get; }
    IBalloonTip Item { get; }
    IEnumerator GetEnumerator();
    IBalloonTip Add(string InternalName, string Title, string Message);
}
