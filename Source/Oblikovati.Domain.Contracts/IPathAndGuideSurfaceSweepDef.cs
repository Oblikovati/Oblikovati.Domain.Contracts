namespace Oblikovati.Domain.Contracts;

public interface IPathAndGuideSurfaceSweepDef
{

    ISweepFeature Parent { get; }
    object GuideSurface { get; set; }
}
