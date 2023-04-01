namespace Oblikovati.Contracts.GraphicsDataSets;

public interface IGraphicsDataSetsCollection : IList<IGraphicsDataSetsCollection>
{
    IGraphicsDataSets Item { get; }

    bool NonTransacting { get; }
    IGraphicsDataSets Add(string ClientId);
    IGraphicsDataSets _Add2(string ClientId, bool SaveWithDocument);
    IGraphicsDataSets AddNonTransacting(string ClientId);
}