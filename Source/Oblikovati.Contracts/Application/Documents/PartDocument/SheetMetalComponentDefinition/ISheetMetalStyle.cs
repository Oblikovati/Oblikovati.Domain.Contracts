using Oblikovati.Contracts.Application.Documents.DrawingDocument.DrawingStylesManager;
using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;

public interface ISheetMetalStyle
{
    IDrawingStylesManager _Parent { get; }

    string Name { get; set; }
    string InternalName { get; }
    bool InUse { get; }
    StyleLocationEnum StyleLocation { get; }
    bool UpToDate { get; }
    StyleTypeEnum StyleType { get; }
    string Comments { get; set; }

    string BendRadius { get; set; }
    BendReliefShapeEnum BendReliefShape { get; set; }
    string MinimumRemnant { get; set; }
    string BendReliefWidth { get; set; }
    BendTransitionEnum BendTransition { get; set; }
    string BendReliefDepth { get; set; }
    string CornerReliefSize { get; set; }
    CornerReliefShapeEnum CornerReliefShape { get; set; }
    PunchRepresentationTypeEnum PunchRepresentationType { get; set; }
    string BendTransitionArcRadius { get; set; }
    CornerReliefShapeEnum ThreeBendCornerReliefShape { get; set; }
    string ThreeBendCornerReliefSize { get; set; }
    IMaterial Material { get; set; }
    string Thickness { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }
    BendAngleTypeEnum BendAngleReportType { get; set; }
    string GapSize { get; set; }
    CornerReliefPlacementEnum CornerReliefPlacement { get; set; }
    void Delete();
    void SaveToGlobal();
    void UpdateFromGlobal();
    IStyle ConvertToLocal();
    IStyle Copy(string Name);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Activate();
}