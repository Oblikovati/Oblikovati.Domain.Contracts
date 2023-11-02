using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.NotClassified;

public interface ILineAndTangentWorkPlaneDef
{
    IWorkPlane Parent { get; }
    object Line { get; }
    IFace Face { get; }
    IPoint ProximityPoint { get; }
    void GetData(out object Line, out IFace Face, out IPoint ProximityPoint);
}