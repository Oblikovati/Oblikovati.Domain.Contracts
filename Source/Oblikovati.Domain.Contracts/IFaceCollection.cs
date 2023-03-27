using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IFaceCollection : IList<object>
{
    FaceCollectionEnum CollectionType { get; }
    void Remove(int Index);
    void RemoveByObject(object Object);
}
