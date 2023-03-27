namespace Oblikovati.Domain.Contracts.Rendering;

public struct RendererCapabilities
{
    string Vendor;
    string Device;
    string Version;
    int MaxSamples;
    float MaxAnisotropy;
    int MaxTextureUnits;
}