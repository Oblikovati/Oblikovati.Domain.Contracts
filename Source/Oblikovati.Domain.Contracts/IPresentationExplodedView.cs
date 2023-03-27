using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

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
