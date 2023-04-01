using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMExchangeServer
{
    IBIMComponent GetBIMComponent(IComponentDefinition ComponentDefinition);
}