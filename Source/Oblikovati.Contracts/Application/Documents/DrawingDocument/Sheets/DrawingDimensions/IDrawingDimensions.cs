using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface IDrawingDimensions : IList<IDrawingDimensions>
{
    IDrawingDimension Item { get; }

    IGeneralDimensions GeneralDimensions { get; }
    IOrdinateDimensions OrdinateDimensions { get; }
    IBaselineDimensionSets BaselineDimensionSets { get; }
    IOrdinateDimensionSets OrdinateDimensionSets { get; }
    IChainDimensionSets ChainDimensionSets { get; }

    void Arrange(IObjectCollection DrawingDimensions, object ContourEntity);
}