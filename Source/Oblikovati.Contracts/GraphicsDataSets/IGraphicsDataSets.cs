using Oblikovati.Contracts.ClientGraphics.GraphicsNode;

namespace Oblikovati.Contracts.GraphicsDataSets;

public interface IGraphicsDataSets : IList<IGraphicsDataSet>
{
    IGraphicsDataSetsCollection Parent { get; }

    IGraphicsDataSet this[string index] { get; }
    string ClientId { get; }
    bool SaveWithDocument { get; }
    bool NonTransacting { get; }
    IGraphicsCoordinateSet CreateCoordinateSet(int DataSetId);
    IGraphicsImageSet CreateImageSet(int DataSetId);
    IGraphicsNormalSet CreateNormalSet(int DataSetId);
    IGraphicsColorSet CreateColorSet(int DataSetId);
    IGraphicsIndexSet CreateIndexSet(int DataSetId);
    void Delete();
    IGraphicsTextureCoordinateSet CreateTextureCoordinateSet(int DataSetId);
    IGraphicsColorMapper CreateColorMapper();
}