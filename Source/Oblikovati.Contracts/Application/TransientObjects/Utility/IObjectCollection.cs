namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface IObjectCollection : IList<object>
{
    void Remove(int Index);
    void RemoveByObject(object Object);
}