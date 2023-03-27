namespace Oblikovati.Domain.Contracts;

public interface IBoundaryPatchDefinition
{

    IBoundaryPatchLoops BoundaryPatchLoops { get; }
    IObjectCollection GuideRails { get; set; }
}
