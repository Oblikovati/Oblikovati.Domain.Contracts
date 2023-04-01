using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchFixedSplines : IList<ISketchFixedSplines>
{
    ISketchFixedSpline Item { get; }


    ISketchFixedSpline Add(IBSplineCurve2d SplineCurve, object StartPoint, object EndPoint);
}