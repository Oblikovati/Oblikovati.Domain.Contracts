using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts;

public interface IBoundaryPatchDefinition
{
    IBoundaryPatchLoops BoundaryPatchLoops { get; }
    IObjectCollection GuideRails { get; set; }
}