using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface IHoleTableColumns : IList<IHoleTableColumns>
{
    IHoleTableColumn Item { get; }


    IHoleTableColumn Add(HolePropertyEnum PropertyType, string CustomPropertyName, int TargetIndex, bool InsertBefore);
}