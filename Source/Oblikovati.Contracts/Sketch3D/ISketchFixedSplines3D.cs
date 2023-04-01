using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchFixedSplines3D : IList<ISketchFixedSplines3D>
{
    ISketchFixedSpline3D Item { get; }


    ISketchFixedSpline3D Add(IBSplineCurve SplineCurve, object StartPoint, object EndPoint);
    ISketchFixedSpline3D AddByEdge(IEdge TransientEdge);
}