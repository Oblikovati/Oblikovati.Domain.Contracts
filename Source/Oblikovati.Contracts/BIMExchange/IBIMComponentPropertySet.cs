namespace Oblikovati.Contracts.BIMExchange;

public interface IBIMComponentPropertySet : IList<IBIMComponentPropertySet>
{
    IBIMComponent Parent { get; }

    IBIMComponentProperty Item { get; }
    string InternalName { get; }
    string Name { get; }
}