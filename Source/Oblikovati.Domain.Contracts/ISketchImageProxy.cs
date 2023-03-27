namespace Oblikovati.Domain.Contracts;

public interface ISketchImageProxy
{


    IAttributeSets AttributeSets { get; }
    ISketchEntitiesEnumerator BoundaryGeometry { get; }
    bool LinkedToFile { get; }
    string Name { get; set; }
    IPoint2d Position { get; set; }
    double Height { get; set; }
    double Width { get; set; }
    IReferencedOLEFileDescriptor ReferencedFileDescriptor { get; }
    bool Transparent { get; set; }
    bool Visible { get; set; }
    ISketchBlock ContainingSketchBlock { get; }
    ISketchBlocksEnumerator SketchBlockPath { get; }
    ISketchImage NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void MirrorHorizontal();
    void MirrorVertical();
    void RotateLeft();
    void RotateRight();
    void Update();
}
