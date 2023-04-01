using Oblikovati.Contracts.Application.TransientGeometry;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchImages : IList<ISketchImages>
{
    ISketchImage Item { get; }


    ISketchImage Add(string FullFileName, IPoint2d Position, bool Link);
}