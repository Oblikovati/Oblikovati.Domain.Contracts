namespace Oblikovati.Contracts;

public interface ITwoPlanesWorkAxisDef
{
    IWorkAxis Parent { get; }
    object Plane1 { get; }
    object Plane2 { get; }
    void GetData(out object Plane1, out object Plane2);
}