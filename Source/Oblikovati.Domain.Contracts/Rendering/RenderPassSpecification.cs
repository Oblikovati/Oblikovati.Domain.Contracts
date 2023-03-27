using System.Numerics;

namespace Oblikovati.Domain.Contracts.Rendering;

public struct RenderPassSpecification
{
    IFramebuffer TargetFramebuffer;
    string DebugName;
    Vector4 MarkerColor;
}