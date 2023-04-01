using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchLines : IList<ISketchLines>
{
    ISketchLine Item { get; }

    ISketchLine AddByTwoPoints(object StartPoint, object EndPoint);
    ISketchEntitiesEnumerator AddAsTwoPointRectangle(object CornerPointOne, object CornerPointTwo);
    ISketchEntitiesEnumerator AddAsThreePointRectangle(object BasePointOne, object BasePointTwo, IPoint2d HeightPoint);
    ISketchEntitiesEnumerator AddAsTwoPointCenteredRectangle(object CenterPoint, object CornerPoint);

    ISketchEntitiesEnumerator AddAsThreePointCenteredRectangle(object CenterPoint, object EdgePoint,
        IPoint2d WidthPoint);

    ISketchEntitiesEnumerator AddAsPolygon(int NumberOfSides, object CenterPoint, object CircumferencePoint,
        bool Inscribed);
}