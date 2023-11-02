namespace Oblikovati.Contracts.NotClassified;

public interface IPlaneAndPointWorkPlaneDef
{
    IWorkPlane Parent { get; }
    object Plane { get; }
    object Point { get; }
    void GetData(out object Plane, out object Point);
}