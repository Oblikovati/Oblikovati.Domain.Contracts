namespace Oblikovati.Domain.Contracts;

public interface ILinePlaneAndAngleWorkPlaneDef
{

    IWorkPlane Parent { get; }
    object Line { get; }
    object Plane { get; }
    IParameter Angle { get; }
    void GetData(out object Line, out object Plane, out IParameter Angle);
}
