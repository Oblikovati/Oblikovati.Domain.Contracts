using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.NotClassified;

public interface ICosmeticWelds : IList<ICosmeticWelds>
{
    ICosmeticWeld Item { get; }

    ICosmeticWeld Add(ICosmeticWeldDefinition CosmeticWeldDefinition);
    ICosmeticWeldDefinition CreateDefinition(IEdgeCollection Edges);
}