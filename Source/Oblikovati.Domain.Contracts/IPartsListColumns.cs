using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IPartsListColumns : IList<IPartsListColumns>
{

    IPartsListColumn Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPartsListColumn Add(PropertyTypeEnum PropertyType, string PropertySetId, object PropertyIdentifier, int TargetIndex, bool InsertBefore);
}
