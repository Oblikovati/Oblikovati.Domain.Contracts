namespace Oblikovati.Domain.Contracts;

public interface IRadiusDimConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Driven { get; set; }
    IParameter Parameter { get; }
    IPoint TextPoint { get; set; }
    IPlane DimensionPlane { get; }
    bool Visible { get; set; }
    IObjectCollection AnchorPoints { get; }
    ISketchEntity3D Entity { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
