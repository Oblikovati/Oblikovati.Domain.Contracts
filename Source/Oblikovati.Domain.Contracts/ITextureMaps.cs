namespace Oblikovati.Domain.Contracts;

public interface ITextureMaps : IList<ITextureMaps>
{
    ITextureMap Item { get; }

    int Count { get; }
    IEnumerator GetEnumerator();
}
