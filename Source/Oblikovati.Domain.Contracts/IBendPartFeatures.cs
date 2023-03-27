using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBendPartFeatures : IList<IBendPartFeatures>
{

    IBendPartFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBendPartFeature Add(ISketchLine BendLine, BendPartTypeEnum BendPartType, object InputOne, object InputTwo, PartFeatureExtentDirectionEnum BendSide, bool BendInSketchNormalDirection, object Body, bool BendMinimum);
}
