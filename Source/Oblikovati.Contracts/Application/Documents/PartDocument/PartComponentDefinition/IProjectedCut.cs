using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IProjectedCut
{
    IAttributeSets AttributeSets { get; }
    string Name { get; set; }
    IPlanarSketch Parent { get; }
    ISketchEntitiesEnumerator SketchEntities { get; }
    void BreakLink();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}