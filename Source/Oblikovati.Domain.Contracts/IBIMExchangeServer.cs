namespace Oblikovati.Domain.Contracts;

public interface IBIMExchangeServer
{
    IBIMComponent GetBIMComponent(IComponentDefinition ComponentDefinition);
}
