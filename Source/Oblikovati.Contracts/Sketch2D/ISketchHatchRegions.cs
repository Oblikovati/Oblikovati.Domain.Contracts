using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchHatchRegions : IList<ISketchHatchRegions>
{
    ISketchHatchRegion Item { get; }


    ISketchHatchRegion Add(IProfile Profile, object DrawingHatchPattern, object Angle, object Scale, object Shift,
        object LineWeight, object DoublePattern, object Color);
}