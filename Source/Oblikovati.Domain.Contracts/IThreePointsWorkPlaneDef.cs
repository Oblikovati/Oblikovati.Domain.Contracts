namespace Oblikovati.Domain.Contracts;

public interface IThreePointsWorkPlaneDef
{

    IWorkPlane Parent { get; }
    object Point1 { get; }
    object Point2 { get; }
    object Point3 { get; }
    void GetData(out object Point1, out object Point2, out object Point3);
}
