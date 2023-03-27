namespace Oblikovati.Domain.Contracts;

public interface IPlaneAndOffsetWorkPlaneDef
{

    IWorkPlane Parent { get; }
    object Plane { get; }
    IParameter Offset { get; }
    void GetData(out object Plane, out IParameter Offset);
}
