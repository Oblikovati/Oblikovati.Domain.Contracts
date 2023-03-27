namespace Oblikovati.Domain.Contracts;

public interface ISketchPoints : IList<ISketchPoint>
{

    ISketchPoint Add(IPoint2d Point, bool HoleCenter);
}
