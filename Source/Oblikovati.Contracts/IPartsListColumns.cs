using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IPartsListColumns : IList<IPartsListColumns>
{
    IPartsListColumn Item { get; }


    IPartsListColumn Add(PropertyTypeEnum PropertyType, string PropertySetId, object PropertyIdentifier,
        int TargetIndex, bool InsertBefore);
}