namespace Oblikovati.Contracts.Application.TransientObjects.Utility;

public interface IObjectCollectionByVariant : IList<object>
{
    void Add(string StringIndex, object Object);
}