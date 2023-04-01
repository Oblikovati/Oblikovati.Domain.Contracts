using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface IEdgeCollection : IList<object>
{
    EdgeCollectionEnum CollectionType { get; }
    void Remove(int Index);
    void RemoveByObject(object Object);
}