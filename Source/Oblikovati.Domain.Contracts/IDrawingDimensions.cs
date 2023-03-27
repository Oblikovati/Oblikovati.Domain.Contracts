namespace Oblikovati.Domain.Contracts;

public interface IDrawingDimensions : IList<IDrawingDimensions>
{

    IDrawingDimension Item { get; }
    int Count { get; }
    IGeneralDimensions GeneralDimensions { get; }
    IOrdinateDimensions OrdinateDimensions { get; }
    IBaselineDimensionSets BaselineDimensionSets { get; }
    IOrdinateDimensionSets OrdinateDimensionSets { get; }
    IChainDimensionSets ChainDimensionSets { get; }
    IEnumerator GetEnumerator();
    void Arrange(IObjectCollection DrawingDimensions, object ContourEntity);
}
