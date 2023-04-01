namespace Oblikovati.Contracts;

public interface ITextureMaps : IList<ITextureMaps>
{
    ITextureMap Item { get; }
}