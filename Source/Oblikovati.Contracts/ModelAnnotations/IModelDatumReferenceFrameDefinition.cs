using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelDatumReferenceFrameDefinition
{
    IModelDatumReferenceFrame Parent { get; }
    IMatrix CoordinateSystem { get; set; }
    IModelToleranceFeature PrimaryDatum { get; set; }
    IModelToleranceFeature SecondaryDatum { get; set; }
    IModelToleranceFeature TertiaryDatum { get; set; }
    IModelToleranceFeature PrimaryCompoundDatum { get; set; }
    IModelToleranceFeature SecondaryCompoundDatum { get; set; }
    IModelToleranceFeature TertiaryCompoundDatum { get; set; }
    MaterialConditionEnum PrimaryMaterialCondition { get; set; }
    MaterialConditionEnum SecondaryMaterialCondition { get; set; }
    MaterialConditionEnum TertiaryMaterialCondition { get; set; }
    MaterialConditionEnum PrimaryCompoundMaterialCondition { get; set; }
    MaterialConditionEnum SecondaryCompoundMaterialCondition { get; set; }
    MaterialConditionEnum TertiaryCompoundMaterialCondition { get; set; }
    IModelDatumReferenceFrameDefinition Copy();
}