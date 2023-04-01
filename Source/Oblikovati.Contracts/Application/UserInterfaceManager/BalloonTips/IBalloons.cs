using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

public interface IBalloons : IList<IBalloons>
{
    IBalloon Item { get; }


    IBalloon Add(IObjectCollection LeaderPoints, object VirtualComponent, object Level, object NumberingScheme,
        object BalloonStyle, object Layer);
}