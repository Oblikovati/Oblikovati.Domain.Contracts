namespace Oblikovati.Contracts.Sketch3D;

public interface IIntersectionCurves : IList<IIntersectionCurves>
{
    IIntersectionCurve Item { get; }

    IIntersectionCurve Add(object EntityOne, object EntityTwo);
}