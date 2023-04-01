using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchFillRegions : IList<ISketchFillRegions>
{
    ISketchFillRegion Item { get; }


    ISketchFillRegion Add(IProfile Profile, object Color);
}