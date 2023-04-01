using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchCircles3D : IList<ISketchCircles3D>
{
    ISketchCircle3D Item { get; }

    ISketchCircle3D AddByCenterRadius(object CenterPoint, IUnitVector Normal, double Radius);
    ISketchCircle3D AddByThreePoints(object StartPoint, object MidPoint, object EndPoint);
}