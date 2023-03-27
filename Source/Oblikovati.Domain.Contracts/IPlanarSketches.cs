namespace Oblikovati.Domain.Contracts;

public interface IPlanarSketches : IList<IPlanarSketch>
{
    IPlanarSketch this[string Index] { get; }

    IPlanarSketch Add(object PlanarEntity, bool UseFaceEdges);
    IPlanarSketch AddWithOrientation(object PlanarEntity, object AxisEntity, bool NaturalAxisDirection, bool AxisIsX, object Origin, bool UseFaceEdges);
}
