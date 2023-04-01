using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchSplines3D : IList<ISketchSplines3D>
{
    ISketchSpline3D Item { get; }

    ISketchSpline3D Add(IObjectCollection FitPoints, SplineFitMethodEnum FitMethod);
}