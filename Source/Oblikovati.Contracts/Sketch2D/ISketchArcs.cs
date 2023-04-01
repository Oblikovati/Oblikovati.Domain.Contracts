using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchArcs : IList<ISketchArcs>
{
    ISketchArc Item { get; }

    ISketchArc AddByCenterStartEndPoint(object CenterPoint, object StartPoint, object EndPoint, bool CounterClockwise);
    ISketchArc AddByCenterStartSweepAngle(object CenterPoint, double Radius, double StartAngle, double SweepAngle);
    ISketchArc AddByThreePoints(object StartPoint, IPoint2d MidPoint, object EndPoint);

    ISketchArc AddByFillet(ISketchEntity EntityOne, ISketchEntity EntityTwo, object Radius, IPoint2d PointOnEntityOne,
        IPoint2d PointOnEntityTwo);
}