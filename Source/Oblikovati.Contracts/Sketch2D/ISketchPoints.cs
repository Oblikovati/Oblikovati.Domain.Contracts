using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchPoints : IList<ISketchPoint>
{
    ISketchPoint Add(IPoint2d Point, bool HoleCenter);
}