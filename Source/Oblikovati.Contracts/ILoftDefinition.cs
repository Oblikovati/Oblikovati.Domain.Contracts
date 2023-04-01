using Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface ILoftDefinition
{
    object Centerline { get; set; }
    bool Closed { get; set; }
    object FirstSectionAngle { get; set; }
    LoftConditionEnum FirstSectionCondition { get; set; }
    object FirstSectionImpact { get; set; }
    bool FirstSectionDirectionReversed { get; set; }
    object FirstSectionTangentPlane { get; set; }
    object LastSectionAngle { get; set; }
    LoftConditionEnum LastSectionCondition { get; set; }
    object LastSectionImpact { get; set; }
    bool LastSectionDirectionReversed { get; set; }
    object LastSectionTangentPlane { get; set; }
    ILoftRails LoftRails { get; }
    ILoftSectionDimensions LoftSectionDimensions { get; }
    IMapPointCurves MapPointCurves { get; set; }
    bool MergeTangentFaces { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IObjectCollection Sections { get; set; }
    LoftTypeEnum LoftType { get; }
    ILoftDefinition Copy();
}