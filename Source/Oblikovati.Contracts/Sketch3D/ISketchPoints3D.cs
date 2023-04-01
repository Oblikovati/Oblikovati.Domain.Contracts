using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchPoints3D : IList<ISketchPoints3D>
{
    ISketchPoint3D Item { get; }

    ISketchPoint3D Add(IPoint Point, bool HoleCenter);
}