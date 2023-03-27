using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILoftFeatures : IList<ILoftFeatures>
{

    ILoftFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IMapPointCurves CreateMapCurves(IObjectCollection Sections);
    ILoftFeature _Add(IObjectCollection Sections, PartFeatureOperationEnum Operation, LoftConditionEnum StartSectionCondition, object StartSectionImpact, object StartSectionAngle, LoftConditionEnum EndSectionCondition, object EndSectionImpact, object EndSectionAngle, bool Closed, object Rails, object MapPointCurves);
    ILoftFeature Add(ILoftDefinition Definition);
    ILoftDefinition CreateLoftDefinition(IObjectCollection Sections, PartFeatureOperationEnum Operation);
}
