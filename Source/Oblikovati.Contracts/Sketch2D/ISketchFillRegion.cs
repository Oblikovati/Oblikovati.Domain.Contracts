using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchFillRegion
{
    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    IProfile Profile { get; }
    IColor Color { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}