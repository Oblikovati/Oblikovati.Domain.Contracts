using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchSplines3D : IList<ISketchSplines3D>
{

    int Count { get; }
    ISketchSpline3D Item { get; }
    IEnumerator GetEnumerator();
    ISketchSpline3D Add(IObjectCollection FitPoints, SplineFitMethodEnum FitMethod);
}
