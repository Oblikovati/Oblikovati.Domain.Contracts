using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IHoleTableColumns : IList<IHoleTableColumns>
{

    IHoleTableColumn Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IHoleTableColumn Add(HolePropertyEnum PropertyType, string CustomPropertyName, int TargetIndex, bool InsertBefore);
}
