using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Sketch2D;

public interface ISketchHolePlacementDefinition
{
    IHoleFeature Parent { get; }
    IObjectCollection HoleCenterPoints { get; set; }
}