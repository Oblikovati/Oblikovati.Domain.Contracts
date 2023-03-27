namespace Oblikovati.Domain.Contracts;

public interface ISketchLines : IList<ISketchLines>
{

    int Count { get; }
    ISketchLine Item { get; }
    IEnumerator GetEnumerator();
    ISketchLine AddByTwoPoints(object StartPoint, object EndPoint);
    ISketchEntitiesEnumerator AddAsTwoPointRectangle(object CornerPointOne, object CornerPointTwo);
    ISketchEntitiesEnumerator AddAsThreePointRectangle(object BasePointOne, object BasePointTwo, IPoint2d HeightPoint);
    ISketchEntitiesEnumerator AddAsTwoPointCenteredRectangle(object CenterPoint, object CornerPoint);
    ISketchEntitiesEnumerator AddAsThreePointCenteredRectangle(object CenterPoint, object EdgePoint, IPoint2d WidthPoint);
    ISketchEntitiesEnumerator AddAsPolygon(int NumberOfSides, object CenterPoint, object CircumferencePoint, bool Inscribed);
}
