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

namespace Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;

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

    void GetSelectedObject(IGenericObject Selection, out ObjectType ObjectType, out INameValueMap AdditionalData,
        out IComponentOccurrence ContainingOccurrence, ref object SelectedObject);

    void ExecutePromptToChoose3daStyle();
    void CheckAssemblyAndPromptOnError(out bool Result);
}