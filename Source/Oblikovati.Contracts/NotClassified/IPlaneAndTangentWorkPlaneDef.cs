using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface IPlaneAndTangentWorkPlaneDef
{
    IWorkPlane Parent { get; }
    object Plane { get; }
    IFace Face { get; }
    IPoint ProximityPoint { get; }
    void GetData(out object Plane, out IFace Face, out IPoint ProximityPoint);
}