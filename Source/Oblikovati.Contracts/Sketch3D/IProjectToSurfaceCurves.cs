using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch3D;

public interface IProjectToSurfaceCurves : IList<IProjectToSurfaceCurves>
{
    IProjectToSurfaceCurve Item { get; }

    IProjectToSurfaceCurve Add(IObjectCollection Faces, IObjectCollection Curves, object ProjectionType,
        object ProjectDirection);
}