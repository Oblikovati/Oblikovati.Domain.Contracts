using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface ISelectionPreferences : IList<ISelectionPreferences>
{
    void Add(ObjectTypeEnum Type, object Index);
    void Remove(int Index);
}