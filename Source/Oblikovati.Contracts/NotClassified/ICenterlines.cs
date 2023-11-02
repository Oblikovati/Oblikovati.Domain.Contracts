using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.ClientGraphics.DrawingView;

namespace Oblikovati.Contracts.NotClassified;

public interface ICenterlines : IList<ICenterlines>
{
    ICenterline Item { get; }


    ICenterline Add(IObjectCollection CenterEntities, object CentermarkStyle, object Layer, bool Closed);
    ICenterline AddBisector(IGeometryIntent EntityOne, IGeometryIntent EntityTwo, object CentermarkStyle, object Layer);
    ICenterline AddByWorkFeature(object WorkFeature, IDrawingView DrawingView, object CentermarkStyle, object Layer);

    ICenterline AddCenteredPattern(IGeometryIntent PatternCenter, IObjectCollection CenterEntities,
        object CentermarkStyle, object Layer, bool Closed);
}