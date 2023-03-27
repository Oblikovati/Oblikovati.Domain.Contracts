namespace Oblikovati.Domain.Contracts;

public interface ITeardropHemDefinition
{
    IHemDefinition Parent { get; }
    IParameter Radius { get; }
    IParameter Angle { get; }
}
