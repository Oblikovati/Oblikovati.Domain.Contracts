using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.Document;

public interface ISelectSet : IList<ISelectSet>
{
    object Item { get; }
    void Select(object Entity);
    void Remove(object Index);
    void Delete();
    void SelectMultiple(IObjectCollection Entities);
}