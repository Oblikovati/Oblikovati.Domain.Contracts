namespace Oblikovati.Contracts;

public interface ITorusMidPlaneWorkPlaneDef
{
    IWorkPlane Parent { get; }
    IFace Face { get; }
}