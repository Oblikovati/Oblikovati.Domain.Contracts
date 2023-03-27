namespace Oblikovati.Domain.Contracts.Rendering;

public interface IRenderEnvironment
{
    ITextureCube RadianceMap { get; }
    ITextureCube IrradianceMap { get; }
}
