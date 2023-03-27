namespace Oblikovati.Domain.Contracts.Rendering;

public enum FramebufferBlendMode
{
    None = 0,
    OneZero,
    SrcAlphaOneMinusSrcAlpha,
    Additive,
    Zero_SrcColor
}