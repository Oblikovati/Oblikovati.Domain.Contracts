namespace Oblikovati.Domain.Contracts;

public interface ISplineFitPointsConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Deletable { get; }
    object Spline { get; }
    IObjectCollection Points { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
