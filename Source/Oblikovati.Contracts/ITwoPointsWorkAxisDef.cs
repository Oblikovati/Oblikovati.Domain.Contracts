namespace Oblikovati.Contracts;

public interface ITwoPointsWorkAxisDef
{
    IWorkAxis Parent { get; }
    object Point1 { get; }
    object Point2 { get; }
    void GetData(out object Point1, out object Point2);
}