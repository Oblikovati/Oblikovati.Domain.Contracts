namespace Oblikovati.Domain.Contracts;

public interface ISurfaceBodyDefinition
{

    IEdgeDefinitions EdgeDefinitions { get; }
    ILumpDefinitions LumpDefinitions { get; }
    IVertexDefinitions VertexDefinitions { get; }
    ISurfaceBody CreateTransientSurfaceBody(out INameValueMap Errors, object Options);
}
