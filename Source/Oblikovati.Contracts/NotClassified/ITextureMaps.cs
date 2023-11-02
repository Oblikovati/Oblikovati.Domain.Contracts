namespace Oblikovati.Contracts.NotClassified;

public interface ITextureMaps : IList<ITextureMaps>
{
    ITextureMap Item { get; }
}