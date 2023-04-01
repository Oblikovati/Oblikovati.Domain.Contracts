using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchEllipses : IList<ISketchEllipses>
{
    ISketchEllipse Item { get; }

    ISketchEllipse Add(object CenterPoint, IUnitVector2d MajorAxisVector, double MajorRadius, double MinorRadius);
}