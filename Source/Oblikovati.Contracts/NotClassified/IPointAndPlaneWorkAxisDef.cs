namespace Oblikovati.Contracts.NotClassified;

public interface IPointAndPlaneWorkAxisDef
{
    IWorkAxis Parent { get; }
    object Point { get; }
    object Plane { get; }
    void GetData(out object Point, out object Plane);
}