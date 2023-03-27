namespace Oblikovati.Domain.Contracts;

public interface IPointHolePlacementDefinition
{

    IHoleFeature Parent { get; }
    object Point { get; }
    object Direction { get; }
}
