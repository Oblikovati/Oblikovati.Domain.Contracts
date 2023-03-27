namespace Oblikovati.Domain.Contracts;

public interface IFeatureControlFrames : IList<IFeatureControlFrames>
{

    IFeatureControlFrame Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IFeatureControlFrameRows CreateFeatureControlFrameRows();
    IFeatureControlFrame Add(IObjectCollection LeaderPoints, IFeatureControlFrameRows FeatureControlFrameRows, bool AllAroundSymbol, string DatumIdentifier, string Notes, object FeatureControlFrameStyle, object Layer);
}
