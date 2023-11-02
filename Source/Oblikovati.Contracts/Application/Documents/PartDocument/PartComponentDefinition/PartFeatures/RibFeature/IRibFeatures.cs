using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.RibFeature;

public interface IRibFeatures : IList<IRibFeatures>
{
    IRibFeature Item { get; }


    IRibFeature Add(IRibDefinition Definition);

    IRibDefinition CreateDefinition(IObjectCollection ProfileCurves, bool IsRib, bool DirectionReversed,
        object Thickness);
}