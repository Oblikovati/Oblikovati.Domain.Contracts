namespace Oblikovati.Domain.Contracts;

public interface IClientGraphicsCollection : IList<IClientGraphics>
{
    public IClientGraphics this[string index] { get; }


    bool NonTransacting { get; }
    IClientGraphics Add(string ClientId);
    IClientGraphics AddNonTransacting(string ClientId);
}
