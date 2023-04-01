namespace Oblikovati.Contracts;

public interface INormalToCurveWorkPlaneDef
{
    IWorkPlane Parent { get; }
    object CurveEntity { get; }
    object Point { get; }
    void GetData(out object CurveEntity, out object Point);
}