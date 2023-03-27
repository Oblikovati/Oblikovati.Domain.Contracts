namespace Oblikovati.Domain.Contracts;

public interface ICenterlines : IList<ICenterlines>
{

    ICenterline Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICenterline Add(IObjectCollection CenterEntities, object CentermarkStyle, object Layer, bool Closed);
    ICenterline AddBisector(IGeometryIntent EntityOne, IGeometryIntent EntityTwo, object CentermarkStyle, object Layer);
    ICenterline AddByWorkFeature(object WorkFeature, IDrawingView DrawingView, object CentermarkStyle, object Layer);
    ICenterline AddCenteredPattern(IGeometryIntent PatternCenter, IObjectCollection CenterEntities, object CentermarkStyle, object Layer, bool Closed);
}
