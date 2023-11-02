namespace Oblikovati.Contracts.NotClassified;

public interface ITorusMidPlaneWorkPlaneDef
{
    IWorkPlane Parent { get; }
    IFace Face { get; }
}