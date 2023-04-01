using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets;

public interface IFeatureControlFrames : IList<IFeatureControlFrames>
{
    IFeatureControlFrame Item { get; }


    IFeatureControlFrameRows CreateFeatureControlFrameRows();

    IFeatureControlFrame Add(IObjectCollection LeaderPoints, IFeatureControlFrameRows FeatureControlFrameRows,
        bool AllAroundSymbol, string DatumIdentifier, string Notes, object FeatureControlFrameStyle, object Layer);
}