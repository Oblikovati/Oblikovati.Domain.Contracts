using Oblikovati.Contracts.Application.AssetLibraries;
using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PresentationDocument;

public interface IPresentationExplodedView
{
    string Name { get; }
    ITrailsEnumerator Trails { get; }
    IAsset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    IPresentationTasks Tasks { get; }
    ICamera SavedCamera { get; }
    void Activate();
    void Delete();
    IMatrix GetTransform(IComponentOccurrence Occurrence);
    bool GetVisibility(object Occurrence);
    void SetVisibility(object Occurrence, bool Visible);
    IRenderStyle GetRenderStyle(object Occurrence);
    void SetRenderStyle(object Occurrence, IRenderStyle RenderStyle);
    void GetAnimationParams(out int Intervals, out int Repetitions);
}