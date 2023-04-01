namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IAnnotationPlanes : IList<IAnnotationPlanes>
{
    IAnnotationPlane Item { get; }
}