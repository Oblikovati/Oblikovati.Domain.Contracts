using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISplineLengthDimConstraint3D
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Driven { get; set; }
    IParameter Parameter { get; }
    IPoint TextPoint { get; set; }
    IPlane DimensionPlane { get; }
    bool Visible { get; set; }
    IObjectCollection AnchorPoints { get; }
    ISketchSpline3D Spline { get; }
    HealthStatusEnum HealthStatus { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}
