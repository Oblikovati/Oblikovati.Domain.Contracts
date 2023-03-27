namespace Oblikovati.Domain.Contracts.Rendering;

public enum ImageFormat
{
    None = 0,
    RED8UN,
    RED8UI,
    RED16UI,
    RED32UI,
    RED32F,
    RG8,
    RG16F,
    RG32F,
    RGB,
    RGBA,
    RGBA16F,
    RGBA32F,
    B10R11G11UF,
    SRGB,
    DEPTH32FSTENCIL8UINT,
    DEPTH32F,
    DEPTH24STENCIL8,
    // Defaults
    Depth = DEPTH24STENCIL8,
}