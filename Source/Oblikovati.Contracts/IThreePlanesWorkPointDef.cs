namespace Oblikovati.Contracts;

public interface IThreePlanesWorkPointDef
{
    IWorkPoint Parent { get; }
    object Plane1 { get; }
    object Plane2 { get; }
    object Plane3 { get; }
    void GetData(out object Plane1, out object Plane2, out object Plane3);
}