using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IBossSets : IList<IBossSets>
{

    int Count { get; }
    IBossSet Item { get; }
    IEnumerator GetEnumerator();
    IBossSet Add(IObjectCollection Centers, BossTypeEnum Type, object Diameter, object Offset, object Taper);
}
