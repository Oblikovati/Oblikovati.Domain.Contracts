namespace Oblikovati.Domain.Contracts;

public interface ISketchEllipses : IList<ISketchEllipses>
{

    int Count { get; }
    ISketchEllipse Item { get; }
    IEnumerator GetEnumerator();
    ISketchEllipse Add(object CenterPoint, IUnitVector2d MajorAxisVector, double MajorRadius, double MinorRadius);
}
