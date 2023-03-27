namespace Oblikovati.Domain.Contracts;

public interface ICentermarks : IList<ICentermarks>
{

    ICentermark Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICentermark Add(IGeometryIntent Intent, bool ExtensionLinesVisible, bool AtPunchCenter, object CentermarkStyle, object Layer);
    ICentermark AddByWorkFeature(object WorkFeature, IDrawingView DrawingView, object CentermarkStyle, object Layer);
    ICentermark AddByCenterOfGravity(IDrawingView DrawingView, object CentermarkStyle, object Layer);
}
