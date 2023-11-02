namespace Oblikovati.Contracts.NotClassified;

public interface IPointAndTangentWorkPlaneDef
{
    IWorkPlane Parent { get; }
    object Point { get; }
    IFace Face { get; }
    void GetData(out object Point, out IFace Face);
}