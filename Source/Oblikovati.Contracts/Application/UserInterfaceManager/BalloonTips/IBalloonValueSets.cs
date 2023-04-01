namespace Oblikovati.Contracts.Application.UserInterfaceManager.BalloonTips;

public interface IBalloonValueSets : IList<IBalloonValueSets>
{
    IBalloonValueSet Item { get; }


    IBalloonValueSet Add(object Component);
}