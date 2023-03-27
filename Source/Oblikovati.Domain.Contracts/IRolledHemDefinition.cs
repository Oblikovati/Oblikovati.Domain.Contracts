namespace Oblikovati.Domain.Contracts;

public interface IRolledHemDefinition
{
    IHemDefinition Parent { get; }
    IParameter Radius { get; }
    IParameter Angle { get; }
}
