using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISelectionPreferences : IList<ISelectionPreferences>
{
    int Count { get; }

    void Add(ObjectTypeEnum Type, object Index);
    void Remove(int Index);
    void Clear();
    IEnumerator GetEnumerator();
}
