using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchSplines : IList<ISketchSplines>
{

    int Count { get; }
    ISketchSpline Item { get; }
    IEnumerator GetEnumerator();
    ISketchSpline _Add(IObjectCollection FitPoints);
    ISketchSpline Add(IObjectCollection FitPoints, SplineFitMethodEnum FitMethod);
    ISketchSpline _AddFixedLengthSpline(IObjectCollection FitPoints, SplineFitMethodEnum FitMethod);
}
