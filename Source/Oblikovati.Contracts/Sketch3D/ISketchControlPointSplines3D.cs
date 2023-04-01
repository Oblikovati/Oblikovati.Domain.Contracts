using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchControlPointSplines3D : IList<ISketchControlPointSplines3D>
{
    ISketchControlPointSpline3D Item { get; }

    ISketchControlPointSpline3D Add(IObjectCollection ControlPoints);
}