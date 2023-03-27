namespace Oblikovati.Domain.Contracts.Rendering;

public struct FramebufferTextureSpecification
{
    ImageFormat Format;
    bool Blend;
    FramebufferBlendMode BlendMode;

    public FramebufferTextureSpecification()
    {
        Blend = true;
        BlendMode = FramebufferBlendMode.SrcAlphaOneMinusSrcAlpha;
        Format = new();
    }
    public FramebufferTextureSpecification(ImageFormat format) 
    {
        Blend = true;
        BlendMode = FramebufferBlendMode.SrcAlphaOneMinusSrcAlpha;
        Format = format;
    }
};