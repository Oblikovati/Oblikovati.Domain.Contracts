namespace Oblikovati.Domain.Contracts;

public interface ISketchHolePlacementDefinition
{

    IHoleFeature Parent { get; }
    IObjectCollection HoleCenterPoints { get; set; }
}
