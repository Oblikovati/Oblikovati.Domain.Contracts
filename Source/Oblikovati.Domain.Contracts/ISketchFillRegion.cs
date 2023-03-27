namespace Oblikovati.Domain.Contracts;

public interface ISketchFillRegion
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    IProfile Profile { get; }
    IColor Color { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
