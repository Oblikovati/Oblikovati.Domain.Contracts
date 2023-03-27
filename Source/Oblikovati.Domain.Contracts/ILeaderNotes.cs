namespace Oblikovati.Domain.Contracts;

public interface ILeaderNotes : IList<ILeaderNotes>
{

    ILeaderNote Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ILeaderNote Add(IObjectCollection LeaderPoints, string FormattedText, object DimensionStyle);
}
