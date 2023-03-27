namespace Oblikovati.Domain.Contracts;

public interface ISketchHatchRegions : IList<ISketchHatchRegions>
{

    ISketchHatchRegion Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ISketchHatchRegion Add(IProfile Profile, object DrawingHatchPattern, object Angle, object Scale, object Shift, object LineWeight, object DoublePattern, object Color);
}
