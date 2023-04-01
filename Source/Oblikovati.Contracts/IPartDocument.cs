using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.LightingStyles;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Application.UserInterfaceManager.Environments;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPartDocument : IDocument
{
    bool SketchActive { get; }
    IPartComponentDefinition ComponentDefinition { get; }
    IMaterials Materials { get; }
    IRenderStyle ActiveRenderStyle { get; set; }
    IModelingSettings ModelingSettings { get; }
    ISketchSettings SketchSettings { get; }
    ISketch3DSettings Sketch3DSettings { get; }
    IDisabledCommandList DisabledCommandList { get; }
    IEnvironmentManager EnvironmentManager { get; }
    ILightingStyle ActiveLightingStyle { get; set; }
    ILightingStyles LightingStyles { get; }
    bool IsSubstitutePart { get; set; }
    ReferenceStatusEnum SubstitutePartStatus { get; }
    IObjectVisibility ObjectVisibility { get; }
    IPartComponentDefinitions ComponentDefinitions { get; }
    IDisplaySettings DisplaySettings { get; }
    IAssets Assets { get; }
    IAssetsEnumerator AppearanceAssets { get; }
    IAssetsEnumerator MaterialAssets { get; }
    IAssetsEnumerator PhysicalAssets { get; }
    IAsset ActiveAppearance { get; set; }
    IAsset ActiveMaterial { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    bool IsEmbeddedDocument { get; }
    IDocument EmbeddingDocument { get; }
    IFlatPatternSettings FlatPatternSettings { get; }
    string ActiveAnnotationsStandard { get; set; }
    ITextStylesEnumerator TextStyles { get; }
    string AssociativeForeignFilename { get; }
    bool UpdateSubstitutePart(bool IgnoreErrors);

    void GetSelectedObject(IGenericObject Selection, out ObjectTypeEnum ObjectType, out INameValueMap AdditionalData,
        out IComponentOccurrence ContainingOccurrence, ref object SelectedObject);

    void ExecutePromptToChoose3daStyle();
    void PutGraphicsLevelsOfDetail(int LevelsOfDetail);
    void BatchEdit(string BatchEditParams, out MemberManagerErrorsEnum Error);
}