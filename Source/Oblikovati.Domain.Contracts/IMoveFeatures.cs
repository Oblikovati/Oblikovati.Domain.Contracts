namespace Oblikovati.Domain.Contracts;

public interface IMoveFeatures : IList<IMoveFeatures>
{

    IMoveFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IMoveFeature Add(IMoveDefinition MoveDefinition);
    IMoveDefinition CreateMoveDefinition(IObjectCollection Bodies);
}
