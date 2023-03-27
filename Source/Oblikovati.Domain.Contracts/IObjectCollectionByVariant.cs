namespace Oblikovati.Domain.Contracts;

public interface IObjectCollectionByVariant : IList<object>
{
    void Add(string StringIndex, object Object);
}
