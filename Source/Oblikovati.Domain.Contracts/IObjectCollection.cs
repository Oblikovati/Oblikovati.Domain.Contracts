namespace Oblikovati.Domain.Contracts;

public interface IObjectCollection : IList<object>
{
    void Remove(int Index);
    void RemoveByObject(object Object);
}
