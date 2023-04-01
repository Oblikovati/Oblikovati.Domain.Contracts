namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMComponentPropertySets : IList<IBIMComponentPropertySets>
{
    IBIMComponentPropertySet Item { get; }
}