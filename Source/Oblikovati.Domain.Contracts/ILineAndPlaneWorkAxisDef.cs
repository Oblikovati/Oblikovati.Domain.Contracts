namespace Oblikovati.Domain.Contracts;

public interface ILineAndPlaneWorkAxisDef
{

    IWorkAxis Parent { get; }
    object Line { get; }
    object Plane { get; }
    void GetData(out object Line, out object Plane);
}
