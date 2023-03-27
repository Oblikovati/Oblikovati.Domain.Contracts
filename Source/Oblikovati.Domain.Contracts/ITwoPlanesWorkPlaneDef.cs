namespace Oblikovati.Domain.Contracts;

public interface ITwoPlanesWorkPlaneDef
{

    IWorkPlane Parent { get; }
    object Plane1 { get; }
    object Plane2 { get; }
    void GetData(out object Plane1, out object Plane2);
}
