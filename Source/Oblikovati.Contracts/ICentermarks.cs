using Oblikovati.Contracts.ClientGraphics.DrawingView;

namespace Oblikovati.Contracts;

public interface ICentermarks : IList<ICentermarks>
{
    ICentermark Item { get; }


    ICentermark Add(IGeometryIntent Intent, bool ExtensionLinesVisible, bool AtPunchCenter, object CentermarkStyle,
        object Layer);

    ICentermark AddByWorkFeature(object WorkFeature, IDrawingView DrawingView, object CentermarkStyle, object Layer);
    ICentermark AddByCenterOfGravity(IDrawingView DrawingView, object CentermarkStyle, object Layer);
}