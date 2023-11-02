using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface ILinePlaneAndAngleWorkPlaneDef
{
    IWorkPlane Parent { get; }
    object Line { get; }
    object Plane { get; }
    IParameter Angle { get; }
    void GetData(out object Line, out object Plane, out IParameter Angle);
}