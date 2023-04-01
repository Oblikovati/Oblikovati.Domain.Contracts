using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Leaders;

public interface ILeaderNotes : IList<ILeaderNotes>
{
    ILeaderNote Item { get; }


    ILeaderNote Add(IObjectCollection LeaderPoints, string FormattedText, object DimensionStyle);
}