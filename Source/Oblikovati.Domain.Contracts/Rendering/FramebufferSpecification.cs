using System.Numerics;

namespace Oblikovati.Domain.Contracts.Rendering;

public struct FramebufferSpecification
{
    float Scale;
    uint Width;
    uint Height;
    Vector4 ClearColor;
    float DepthClearValue;
    bool ClearColorOnLoad;
    bool ClearDepthOnLoad;
    FramebufferAttachmentSpecification Attachments;
    uint Samples;
    bool NoResize;
    bool Blend;
    FramebufferBlendMode BlendMode;
    bool SwapChainTarget;
    IImage2D? ExistingImage;
    List<uint>? ExistingImageLayers;
    Dictionary<uint, IImage2D>? ExistingImages;
    IFramebuffer? ExistingFramebuffer;
    string? DebugName;
    public FramebufferSpecification()
    {
        Scale = 1.0f;
        Width = 0;
        Height = 0;
        ClearColor = new(0.0f, 0.0f, 0.0f, 1.0f );
        DepthClearValue = 0.0f;
        ClearColorOnLoad = true;
        ClearDepthOnLoad = true;
        Attachments = new();
        Samples = 1;
        NoResize = false;
        Blend = true;
        BlendMode = FramebufferBlendMode.None;
        SwapChainTarget = false;
        ExistingImage = null;
        ExistingImageLayers = null;
        ExistingFramebuffer = null;
        ExistingImages = null;
        DebugName = "";
    }
};