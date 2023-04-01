using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Sketch2D;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

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