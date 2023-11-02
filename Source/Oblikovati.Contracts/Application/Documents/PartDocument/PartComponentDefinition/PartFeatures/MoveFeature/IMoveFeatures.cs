using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.MoveFeature;

public interface IMoveFeatures : IList<IMoveFeatures>
{
    IMoveFeature Item { get; }


    IMoveFeature Add(IMoveDefinition MoveDefinition);
    IMoveDefinition CreateMoveDefinition(IObjectCollection Bodies);
}