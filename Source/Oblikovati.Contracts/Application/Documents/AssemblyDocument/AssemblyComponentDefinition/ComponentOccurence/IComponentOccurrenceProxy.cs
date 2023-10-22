using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.AssemblyConstraints;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.iMateDefinitions;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;

public interface IComponentOccurrenceProxy
{
    IAssemblyComponentDefinition Parent { get; }
    bool HasBodyOverride { get; }
    ISurfaceBodies SurfaceBodies { get; }
    string Name { get; set; }
    IComponentDefinition ContextDefinition { get; }
    IComponentDefinition Definition { get; }
    DocumentType DefinitionDocumentType { get; }
    IComponentOccurrence ParentOccurrence { get; }
    IComponentOccurrencesEnumerator OccurrencePath { get; }
    IComponentOccurrencesEnumerator SubOccurrences { get; }
    IMatrix Transformation { get; set; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    bool Grounded { get; set; }
    bool Visible { get; set; }
    bool Adaptive { get; set; }
    bool Enabled { get; set; }
    IRenderStyle RenderStyle { get; set; }
    IMassProperties MassProperties { get; }
    IOccurrencePatternElement PatternElement { get; }
    IAttributeSets AttributeSets { get; }
    bool IsiPartMember { get; }
    IiMateDefinitionsEnumerator iMateDefinitions { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    IBox RangeBox { get; }
    string ActivePositionalState { get; set; }
    BOMStructureEnum BOMStructure { get; set; }
    bool Flexible { get; set; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    string ActivePositionalRepresentation { get; set; }
    string ActiveLevelOfDetailRepresentation { get; }
    string ActiveDesignViewRepresentation { get; }
    bool IsiAssemblyMember { get; }
    bool CustomAdaptive { get; set; }
    object InterchangeableComponents { get; set; }
    bool Suppressed { get; }
    double OverrideOpacity { get; set; }
    bool ShowDegreesOfFreedom { get; set; }
    bool IsSubstituteOccurrence { get; }
    bool ContactSet { get; set; }
    bool Excluded { get; set; }
    IReferencedFileDescriptor ReferencedFileDescriptor { get; }
    string _DisplayName { get; }
    IComponentDefinitionReference DefinitionReference { get; }
    bool Reference { get; set; }
    bool LocalAdaptive { get; set; }
    bool Edited { get; }
    bool IsPatternElement { get; }
    bool _IsSimulationOccurrence { get; }
    bool IsAssociativeToDesignViewRepresentation { get; set; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    IAssemblyJointsEnumerator Joints { get; }
    bool IsAssociativelyImported { get; }
    bool HasAssociativeImportedComponent { get; }
    IImportedComponent ImportedComponent { get; }
    bool Transparent { get; set; }
    string AssociativeForeignFilename { get; }
    string ActiveModelState { get; set; }
    IPropertySets OccurrencePropertySets { get; }
    bool OccurrencePropertySetsEnabled { get; set; }
    IComponentOccurrence NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void SetTransformWithoutConstraints(IMatrix Matrix);
    void CreateGeometryProxy(object Geometry, out object Result);
    void Delete();
    void Delete2(bool SkipDocumentSave);
    void Replace(string FileName, bool ReplaceAll);
    void Replace2(string FileName, bool ReplaceAll, object SaveEdits, object KeepAdaptivity);
    IRenderStyle GetRenderStyle(out StyleSourceTypeEnum StyleSourceType);
    void SetRenderStyle(StyleSourceTypeEnum StyleSourceType, object RenderStyle);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void ChangeRowOfiPartMember(object NewRow, object CustomInput);
    void Edit();
    DisplayModeEnum GetDisplayMode(out DisplayModeSourceTypeEnum DisplayModeSourceType);
    void SetDisplayMode(DisplayModeSourceTypeEnum DisplayModeSourceType, object DisplayMode);
    void SetLevelOfDetailRepresentation(string Representation, bool SkipDocumentSave);
    void SetDesignViewRepresentation(string Representation, string Reserved, bool Associative);
    void ChangeRowOfiAssemblyMember(object NewRow, object Options);
    void Suppress(bool SkipDocumentSave);
    void Unsuppress();
    void ExitEdit(ExitTypeEnum ExitTo);

    void GetDegreesOfFreedom(out int TranslationDegreesCount, out IObjectsEnumerator TranslationDegreesVectors,
        out int RotationDegreesCount, out IObjectsEnumerator RotationDegreesVectors, out IPoint DOFCenter);

    void _Replace(string FileName, bool ReplaceAll);
    void _GetDisplayMode(out DisplayModeSourceTypeEnum DisplayModeSourceType);
    void ShowRelationships();
}