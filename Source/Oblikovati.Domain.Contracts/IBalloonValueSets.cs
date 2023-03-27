namespace Oblikovati.Domain.Contracts;

public interface IBalloonValueSets : IList<IBalloonValueSets>
{

    IBalloonValueSet Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IBalloonValueSet Add(object Component);
}
