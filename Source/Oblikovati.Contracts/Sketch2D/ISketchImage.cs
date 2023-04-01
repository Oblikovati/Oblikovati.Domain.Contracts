using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Attributes;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchImage
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
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void MirrorHorizontal();
    void MirrorVertical();
    void RotateLeft();
    void RotateRight();
    void Update();
}