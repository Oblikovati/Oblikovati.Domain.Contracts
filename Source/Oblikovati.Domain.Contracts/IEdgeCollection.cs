using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IEdgeCollection : IList<object>
{

    EdgeCollectionEnum CollectionType { get; }
    void Remove(int Index);
    void RemoveByObject(object Object);
}
