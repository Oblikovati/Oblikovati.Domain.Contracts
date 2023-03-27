namespace Oblikovati.Domain.Contracts.Rendering;

public struct PipelineStatistics
{
    ulong InputAssemblyVertices;
    ulong InputAssemblyPrimitives;
    ulong VertexShaderInvocations;
    ulong ClippingInvocations;
    ulong ClippingPrimitives;
    ulong FragmentShaderInvocations;
    ulong ComputeShaderInvocations;
}