namespace Oblikovati.Domain.Contracts;

public interface IRipFeatures : IList<IRipFeatures>
{

    IRipFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRipFeature Add(IRipDefinition RipDefinition);
    IRipDefinition CreateRipDefinition(IFace RipFace);
}
