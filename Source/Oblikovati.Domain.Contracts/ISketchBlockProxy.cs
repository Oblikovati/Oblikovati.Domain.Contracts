using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchBlockProxy
{

    ISketchBlocksEnumerator ChildBlocks { get; }
    ISketchBlock ContainingSketchBlock { get; }
    IColor Color { get; set; }
    string Name { get; set; }
    ISketchBlocksEnumerator SketchBlockPath { get; }
    IMatrix2d Transformation { get; set; }
    IAttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    ISketchBlockDefinition Definition { get; }
    bool Flexible { get; set; }
    bool HasReferenceComponent { get; }
    IPoint2d Position { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    ISketch Parent { get; }
    IReferenceComponent ReferenceComponent { get; }
    ISketchBlock ReferencedEntity { get; }
    bool Visible { get; set; }
    bool Exported { get; set; }
    ISketchBlock NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void Edit();
    void ExitEdit(ExitTypeEnum ExitTo);
    void Explode();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    object GetObject(object ObjectInDefinition);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
