namespace Oblikovati.Domain.Contracts;

public interface IConcentricHolePlacementDefinition
{

    IHoleFeature Parent { get; }
    object Plane { get; }
    object ConcentricReference { get; }
}
