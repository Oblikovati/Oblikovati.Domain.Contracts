namespace Oblikovati.Domain.Contracts;

public interface ISketchEllipticalArcs : IList<ISketchEllipticalArcs>
{

    int Count { get; }
    ISketchEllipticalArc Item { get; }
    IEnumerator GetEnumerator();
    ISketchEllipticalArc Add(object CenterPoint, IUnitVector2d MajorAxisVector, double MajorRadius, double MinorRadius, double StartAngle, double SweepAngle);
}
