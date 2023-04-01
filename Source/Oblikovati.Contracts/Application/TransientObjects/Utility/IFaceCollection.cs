using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface IFaceCollection : IList<object>
{
    FaceCollectionEnum CollectionType { get; }
    void Remove(int Index);
    void RemoveByObject(object Object);
}