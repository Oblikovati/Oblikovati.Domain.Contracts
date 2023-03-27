namespace Oblikovati.Domain.Contracts;

public interface ITorusMidPlaneWorkPlaneDef
{

    IWorkPlane Parent { get; }
    IFace Face { get; }
}
