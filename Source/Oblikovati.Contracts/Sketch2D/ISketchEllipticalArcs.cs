using Oblikovati.Contracts.Application.TransientObjects.Math;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchEllipticalArcs : IList<ISketchEllipticalArcs>
{
    ISketchEllipticalArc Item { get; }

    ISketchEllipticalArc Add(object CenterPoint, IUnitVector2d MajorAxisVector, double MajorRadius, double MinorRadius,
        double StartAngle, double SweepAngle);
}