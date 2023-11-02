using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.LoftFeature;

public interface ILoftFeatures : IList<ILoftFeatures>
{
    ILoftFeature Item { get; }


    IMapPointCurves CreateMapCurves(IObjectCollection Sections);

    ILoftFeature _Add(IObjectCollection Sections, PartFeatureOperationEnum Operation,
        LoftConditionEnum StartSectionCondition, object StartSectionImpact, object StartSectionAngle,
        LoftConditionEnum EndSectionCondition, object EndSectionImpact, object EndSectionAngle, bool Closed,
        object Rails, object MapPointCurves);

    ILoftFeature Add(ILoftDefinition Definition);
    ILoftDefinition CreateLoftDefinition(IObjectCollection Sections, PartFeatureOperationEnum Operation);
}