using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.iFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    PunchToolFeature;

public interface IPunchToolFeatures : IList<IPunchToolFeatures>
{
    IPunchToolFeature Item { get; }


    IPunchToolFeature _Add(IObjectCollection PunchCenterPoints, IiFeatureDefinition Definition, object Angle);

    IPunchToolFeature Add(IObjectCollection PunchCenterPoints, IiFeatureDefinition Definition, object Angle,
        bool AcrossBends);

    IiFeatureDefinition CreateiFeatureDefinition(string FullFileName);
}