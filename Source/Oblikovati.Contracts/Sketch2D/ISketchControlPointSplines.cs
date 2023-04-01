using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchControlPointSplines : IList<ISketchControlPointSplines>
{
    ISketchControlPointSpline Item { get; }

    ISketchControlPointSpline Add(IObjectCollection ControlPoints);
}