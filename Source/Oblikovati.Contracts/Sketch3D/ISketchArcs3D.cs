using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchArcs3D : IList<ISketchArcs3D>
{
    ISketchArc3D Item { get; }

    ISketchArc3D AddAsBend(ISketchLine3D LineOne, ISketchLine3D LineTwo, object BendRadius);

    ISketchArc3D AddByCenterStartEndPoint(object CenterPoint, object StartPoint, object EndPoint, object Normal,
        bool CounterClockwise);

    ISketchArc3D AddByCenterStartSweepAngle(object CenterPoint, IUnitVector Normal, IUnitVector ReferenceVector,
        double Radius, double StartAngle, double SweepAngle);

    ISketchArc3D AddByThreePoints(object StartPoint, object MidPoint, object EndPoint);
}