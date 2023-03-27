using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IAssemblyDocument : IDocument
{
    IAssemblyComponentDefinition ComponentDefinition { get; }
    IModelingSettings ModelingSettings { get; }
    ISketchSettings SketchSettings { get; }
    IMaterials Materials { get; }
    string DesignViewInfo { get; }
    IDisabledCommandList DisabledCommandList { get; }
    IEnvironmentManager EnvironmentManager { get; }
    ILightingStyle ActiveLightingStyle { get; set; }
    ILightingStyles LightingStyles { get; }
    string LevelOfDetailName { get; }
    IObjectVisibility ObjectVisibility { get; }
    bool IsOpenExpress { get; set; }
    ITextStylesEnumerator TextStyles { get; }
    bool IsOpenLightweight { get; set; }
    IAssemblyComponentDefinitions ComponentDefinitions { get; }
    bool _ExcludeFromBOM { get; set; }
    IDisplaySettings DisplaySettings { get; }
    IAssets Assets { get; }
    IAssetsEnumerator AppearanceAssets { get; }
    IAssetsEnumerator MaterialAssets { get; }
    IAssetsEnumerator PhysicalAssets { get; }
    IOGSSceneNode TopOGSSceneNode { get; }
    CachedGraphicsStatusEnum CachedGraphicsStatus { get; }
    bool IsEmbeddedDocument { get; }
    IDocument EmbeddingDocument { get; }
    string ActiveAnnotationsStandard { get; set; }
    string AssociativeForeignFilename { get; }
    void GetSelectedObject(IGenericObject Selection, out ObjectTypeEnum ObjectType, out INameValueMap AdditionalData, out IComponentOccurrence ContainingOccurrence, ref object SelectedObject);
    void ExecutePromptToChoose3daStyle();
    void CheckAssemblyAndPromptOnError(out bool Result);
}
