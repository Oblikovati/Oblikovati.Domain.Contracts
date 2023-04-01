namespace Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

public interface IBalloonTips : IList<IBalloonTips>
{
    IBalloonTip Item { get; }

    IBalloonTip Add(string InternalName, string Title, string Message);
}