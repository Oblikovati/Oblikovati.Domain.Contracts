namespace Oblikovati.Domain.Contracts.Rendering;

public struct ShaderBuffer
{
    string Name { get; }
    uint Size { get; }
    Dictionary<string, IShaderUniform> Uniforms;
};