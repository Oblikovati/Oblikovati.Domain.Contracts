using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchSplines : IList<ISketchSplines>
{
    ISketchSpline Item { get; }

    ISketchSpline _Add(IObjectCollection FitPoints);
    ISketchSpline Add(IObjectCollection FitPoints, SplineFitMethodEnum FitMethod);
    ISketchSpline _AddFixedLengthSpline(IObjectCollection FitPoints, SplineFitMethodEnum FitMethod);
}